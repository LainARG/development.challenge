using DevelopmentChallenge.Data.Classes.Formas;
using System;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes.Reporte.Idiomas
{
    public class LocalizadorCastellano : ILocalizador
    {
        private static readonly Dictionary<TipoForma, (string Singular, string Plural)> _formas =
            new Dictionary<TipoForma, (string Singular, string Plural)>
            {
                { TipoForma.Cuadrado, ("Cuadrado", "Cuadrados") },
                { TipoForma.Circulo, ("Círculo", "Círculos") },
                { TipoForma.TrianguloEquilatero, ("Triángulo", "Triángulos") },
                { TipoForma.Trapecio, ("Trapecio", "Trapecios") }
            };

        public string ListaVacia => "<h1>Lista vacía de formas!</h1>";
        public string Titulo => "<h1>Reporte de Formas</h1>";
        public string Total => "TOTAL:<br/>";
        public string Perimetro => "Perimetro";
        public string Area => "Area";

        public string Formas(int cantidad)
        {
            return cantidad == 1 ? "forma" : "formas";
        }

        public string NombreForma(TipoForma tipo, int cantidad)
        {
            if (!_formas.TryGetValue(tipo, out var nombres))
                throw new ArgumentException($"Forma no válida: {nameof(tipo)}");

            return cantidad == 1 ? nombres.Singular : nombres.Plural;
        }

    }
}
