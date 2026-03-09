using DevelopmentChallenge.Data.Classes.Formas;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DevelopmentChallenge.Data.Classes.Reporte
{
    public static class Reporte
    {
        public static string Imprimir(IEnumerable<FormaGeometrica> formas, ILocalizador texto)
        {
            var listaFormas = formas.ToList();
            var sb = new StringBuilder();

            if (!listaFormas.Any())
                return texto.ListaVacia;

            sb.Append(texto.Titulo);

            var grupos = listaFormas.GroupBy(f => f.Tipo);

            decimal areaTotal = 0m;
            decimal perimetroTotal = 0m;
            int cantidadTotal = 0;

            foreach (var grupo in grupos)
            {
                var cantidad = grupo.Count();
                var area = grupo.Sum(f => f.CalcularArea());
                var perimetro = grupo.Sum(f => f.CalcularPerimetro());

                cantidadTotal += cantidad;
                areaTotal += area;
                perimetroTotal += perimetro;

                sb.Append(ObtenerLinea(cantidad, area, perimetro, grupo.Key, texto));
            }

            sb.Append(texto.Total);
            sb.Append(cantidadTotal + " " + texto.Formas(cantidadTotal) + " ");
            sb.Append(texto.Perimetro + " " + perimetroTotal.ToString("#.##") + " ");
            sb.Append(texto.Area + " " + areaTotal.ToString("#.##"));

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoForma tipo, ILocalizador texto)
        {
            if (cantidad == 0)
                return string.Empty;

            var nombre = texto.NombreForma(tipo, cantidad);

            return string.Format(
                "{0} {1} | {2} {3:#.##} | {4} {5:#.##} <br/>",
                cantidad,
                nombre,
                texto.Area,
                area,
                texto.Perimetro,
                perimetro);
        }
    }
}

