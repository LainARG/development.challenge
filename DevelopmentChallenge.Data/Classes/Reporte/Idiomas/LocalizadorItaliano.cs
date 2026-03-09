using DevelopmentChallenge.Data.Classes.Formas;
using System;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes.Reporte.Idiomas
{
    public class LocalizadorItaliano : ILocalizador
    {
        private static readonly Dictionary<TipoForma, (string Singular, string Plural)> _formas =
            new Dictionary<TipoForma, (string Singular, string Plural)>
            {
                { TipoForma.Cuadrado, ("Quadrato", "Quadrati") },
                { TipoForma.Circulo, ("Cerchio", "Cerchi") },
                { TipoForma.TrianguloEquilatero, ("Triangolo", "Triangoli") },
                { TipoForma.Trapecio, ("Trapezio", "Trapezi") }
            };
        public string ListaVacia => "<h1>Lista vuota di forme!</h1>";
        public string Titulo => "<h1>Rapporto delle Forme</h1>";
        public string Total => "TOTALE:<br/>";
        public string Perimetro => "Perimetro";
        public string Area => "Area";

        public string Formas(int cantidad)
        {
            return cantidad == 1 ? "forma" : "forme";
        }

        public string NombreForma(TipoForma tipo, int cantidad)
        {
            if (!_formas.TryGetValue(tipo, out var nombres))
                throw new ArgumentException($"Forma non valida: {nameof(tipo)}");

            return cantidad == 1 ? nombres.Singular : nombres.Plural;
        }

    }
}
