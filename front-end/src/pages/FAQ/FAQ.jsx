import "./FAQ.css";

export default function FAQ() {
  return (
    <div className="faq-container">
      <h1>Întrebări Frecvente (FAQ)</h1>

      <section>
        <h2>1. Cum pot face o rezervare?</h2>
        <p>
          Pentru a face o rezervare, trebuie să fii înregistrat și autentificat pe platforma noastră. Alege o ofertă, completează detaliile și confirmă rezervarea.
        </p>
      </section>

      <section>
        <h2>2. Care sunt metodele de plată acceptate?</h2>
        <p>
          Acceptăm plata prin card bancar, transfer bancar și plata ramburs la preluarea mașinii, în funcție de oferta aleasă.
        </p>
      </section>

      <section>
        <h2>3. Pot anula sau modifica o rezervare?</h2>
        <p>
          Da, poți anula sau modifica rezervarea prin contul tău, cu cel puțin 24 de ore înainte de data preluării, conform politicii noastre flexibile.
        </p>
      </section>

      <section>
        <h2>4. Ce trebuie să știu despre asigurare?</h2>
        <p>
          Fiecare închiriere include asigurare RCA obligatorie. Opțional, poți adăuga asigurări suplimentare direct în procesul de rezervare.
        </p>
      </section>
    </div>
  );
}
