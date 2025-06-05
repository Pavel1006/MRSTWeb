using System.Linq;
using System.Web;
using Domain.DbContext;
using Domain.Entities;
using Helpers;

namespace BusinessLogic.Core
{
    public class LoginBusiness
    {
        public bool RegisterUser(string username, string email, string password)
        {
            using (var db = new UserContext())
            {
                if (db.Users.Any(u => u.Username == username || u.Email == email))
                    return false;

                var userRole = db.Roles.FirstOrDefault(r => r.Name == "User");

                var newUser = new UDbTable
                {
                    Username = username,
                    Email = email,
                    Password = AES.Encrypt(password),
                    Roles = new System.Collections.Generic.List<Role> { userRole }
                };

                db.Users.Add(newUser);
                db.SaveChanges();
                return true;
            }
        }

        public bool ValidateUser(string username, string password)
        {
            using (var db = new UserContext())
            {
                var user = db.Users.Include("Roles").FirstOrDefault(u => u.Username == username);
                if (user != null && AES.Decrypt(user.Password) == password)
                {
                    string roles = string.Join(",", user.Roles.Select(r => r.Name));
                    var authCookie = new HttpCookie("AuthCookie")
                    {
                        Values =
                        {
                            ["Username"] = username,
                            ["Roles"] = roles
                        },
                        Expires = System.DateTime.Now.AddMinutes(30),
                        HttpOnly = true
                    };
                    HttpContext.Current.Response.Cookies.Add(authCookie);
                    return true;
                }
                return false;
            }
        }
    }
}
