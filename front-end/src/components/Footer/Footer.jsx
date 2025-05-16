import "./Footer.css";

export default function Footer() {
  return (
    <footer className="footer">
      <div className="footer-content">
        <p>© 2025 AutoRent. Toate drepturile rezervate.</p>
        <nav className="footer-nav">
          <a href="/about">About Us</a>
          <a href="/contact">Contact</a>
          <a href="/faq">FAQ</a>
          <a href="/help">Help</a>
        </nav>
      </div>
    </footer>
  );
}
