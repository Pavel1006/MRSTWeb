import { Link } from "react-router-dom";
import "./Navbar.css";

// import { useAuth } from "../../context/AuthContext";

export default function Navbar() {
  // const { user } = useAuth();

  return (
    <nav className="navbar">
      <div className="nav-left">
        <Link to="/">Home</Link>
        <Link to="/about">About</Link>
        <Link to="/contact">Contact</Link>
        <Link to="/faq">FAQ</Link>
        <Link to="/help">Help</Link>
      </div>
      <div className="nav-right">
        <>
          <Link to="/login">Login</Link>
          <Link to="/register">Register</Link>
        </>

        {/* {!user && (
          <>
            <Link to="/login">Login</Link>
            <Link to="/register">Register</Link>
          </>
        )}
        {user && (
          <>
            <Link to="/profile">Profile</Link>
            <Link to="/my-offers">My Offers</Link>
            <Link to="/offer/new">New Offer</Link>
          </>
        )}
        {(user?.role === "admin" || user?.role === "moderator") && (
          <>
            <Link to="/admin/offers">Admin Offers</Link>
            <Link to="/admin/rent-types">Rent Types</Link>
          </>
        )}
        {user && (
          <button className="logout-btn" onClick={logout}>
            Logout
          </button>
        )} */}
      </div>
    </nav>
  );
}
