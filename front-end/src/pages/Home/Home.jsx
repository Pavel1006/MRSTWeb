import { useEffect, useState } from "react";
import "./Home.css";

export default function Home() {
  const [offers, setOffers] = useState([]);

  useEffect(() => {
    fetch("/api/RentOffer/v1")
      .then((res) => res.json())
      .then(setOffers)
      .catch(() => setOffers([]));
  }, []);

  return (
    <div className="home-container">
      <h1>Oferte Mașini de Închiriat</h1>
      <p>
        Descoperă cele mai bune oferte de închiriere auto. Filtrează după preț,
        tip carburant, putere și alte caracteristici pentru a găsi mașina ideală
        pentru tine!
      </p>

      <div className="offers-grid">
        {offers.length === 0 && <p>Momentan nu sunt oferte disponibile.</p>}
        {offers.map((o) => (
          <div key={o.id} className="offer-card">
            <img
              src={o.photos?.[0] || "https://via.placeholder.com/300x200"}
              alt={o.carName}
              className="offer-image"
            />
            <div className="offer-info">
              <h2>
                {o.carName} ({o.carYear})
              </h2>
              <p>Putere: {o.horsepower} CP</p>
              <p>Preț: {o.price} RON / zi</p>
            </div>
            <a href={`/offer/${o.id}`} className="details-link">
              Vezi detalii
            </a>
          </div>
        ))}
      </div>
    </div>
  );
}
