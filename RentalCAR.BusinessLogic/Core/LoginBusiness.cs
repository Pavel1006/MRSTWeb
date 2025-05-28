using System;
using System.Collections.Generic;
using RentalCAR.BusinessLogic
using RentalCAR.Domain.Entities;
using RentalCAR.Helpers;

namespace RentalCAR.BusinessLogic.Core
{
    public class LoginBusiness
    {
        public bool RegisterUser(string username, string email, string password)
        {
            using var db = new UserContext();
            if (db.Users.Any(u => u.Username == username || u.Email == email)) return false;
            db.Users.Add(new UDbTable
            {
                Username = username,
                Email = email,
                Password = AES.Encrypt(password)
            });
            db.SaveChanges();
            return true;
        }

        public bool ValidateUser(string username, string password)
        {
            using var db = new UserContext();
            var user = db.Users.FirstOrDefault(u => u.Username == username);
            return user != null && AES.Decrypt(user.Password) == password;
        }
    }
}