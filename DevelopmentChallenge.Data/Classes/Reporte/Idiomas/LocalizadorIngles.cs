using DevelopmentChallenge.Data.Classes.Formas;
using System;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes.Reporte.Idiomas
{
    public class LocalizadorIngles : ILocalizador
    {
        private static readonly Dictionary<TipoForma, (string Singular, string Plural)> _formas =
            new Dictionary<TipoForma, (string Singular, string Plural)>
            {
                { TipoForma.Cuadrado, ("Square", "Squares") },
                { TipoForma.Circulo, ("Circle", "Circles") },
                { TipoForma.TrianguloEquilatero, ("Triangle", "Triangles") },
                { TipoForma.Trapecio, ("Trapezoid", "Trapezoids") }
            };
        public string ListaVacia => "<h1>Empty list of shapes!</h1>";
        public string Titulo => "<h1>Shapes report</h1>";
        public string Total => "TOTAL:<br/>";
        public string Perimetro => "Perimeter";
        public string Area => "Area";

        public string Formas(int cantidad)
        {
            return cantidad == 1 ? "shape" : "shapes";
        }

        public string NombreForma(TipoForma tipo, int cantidad)
        {
            if (!_formas.TryGetValue(tipo, out var nombres))
                throw new ArgumentException($"Invalid shape: {nameof(tipo)}");

            return cantidad == 1 ? nombres.Singular : nombres.Plural;
        }

    }
}