using DevelopmentChallenge.Data.Classes.Formas;
using System;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        public abstract TipoForma Tipo { get; }

        public abstract decimal CalcularArea();

        public abstract decimal CalcularPerimetro();

        protected void ValidarMayorACero(decimal valor, string nombreParametro)
        {
            if (valor <= 0)
                throw new ArgumentOutOfRangeException(nombreParametro, "El valor debe ser mayor a cero.");
        }
    }
}

/*
namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        #region Idiomas

        public const int Castellano = 1;
        public const int Ingles = 2;

        #endregion

        private readonly decimal _lado;

        public FormaTipo Tipo { get; set; }

        public FormaGeometrica(FormaTipo tipo, decimal ancho)
        {
            Tipo = tipo;
            _lado = ancho;
        }

        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                if (idioma == Castellano)
                    sb.Append("<h1>Lista vacía de formas!</h1>");
                else
                    sb.Append("<h1>Empty list of shapes!</h1>");
            }
            else
            {
                if (idioma == Castellano)
                    sb.Append("<h1>Reporte de Formas</h1>");
                else
                    sb.Append("<h1>Shapes report</h1>");

                var numeroCuadrados = 0;
                var numeroCirculos = 0;
                var numeroTriangulos = 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;

                for (var i = 0; i < formas.Count; i++)
                {
                    if (formas[i].Tipo == FormaTipo.Cuadrado)
                    {
                        numeroCuadrados++;
                        areaCuadrados += formas[i].CalcularArea();
                        perimetroCuadrados += formas[i].CalcularPerimetro();
                    }

                    if (formas[i].Tipo == FormaTipo.Circulo)
                    {
                        numeroCirculos++;
                        areaCirculos += formas[i].CalcularArea();
                        perimetroCirculos += formas[i].CalcularPerimetro();
                    }

                    if (formas[i].Tipo == FormaTipo.TrianguloEquilatero)
                    {
                        numeroTriangulos++;
                        areaTriangulos += formas[i].CalcularArea();
                        perimetroTriangulos += formas[i].CalcularPerimetro();
                    }
                }

                sb.Append(ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, FormaTipo.Cuadrado, idioma));
                sb.Append(ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, FormaTipo.Circulo, idioma));
                sb.Append(ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, FormaTipo.TrianguloEquilatero, idioma));

                sb.Append("TOTAL:<br/>");
                sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + (idioma == Castellano ? "formas" : "shapes") + " ");
                sb.Append((idioma == Castellano ? "Perimetro " : "Perimeter ") + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos).ToString("#.##") + " ");
                sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos).ToString("#.##"));
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, FormaTipo tipo, int idioma)
        {
            if (cantidad > 0)
            {
                if (idioma == Castellano)
                    return string.Format("{0} {1} | Area {2:#.##} | Perimetro {3:#.##} <br/>", cantidad, TraducirForma(tipo, cantidad, idioma), area, perimetro);

                return string.Format("{0} {1} | Area {2:#.##} | Perimeter {3:#.##} <br/>", cantidad, TraducirForma(tipo, cantidad, idioma), area, perimetro);
            }

            return string.Empty;
        }

        private static string TraducirForma(FormaTipo tipo, int cantidad, int idioma)
        {
            if (tipo == FormaTipo.Cuadrado)
            {
                if (idioma == Castellano) return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                return cantidad == 1 ? "Square" : "Squares";
            }

            if (tipo == FormaTipo.Circulo)
            {
                if (idioma == Castellano) return cantidad == 1 ? "Círculo" : "Círculos";
                return cantidad == 1 ? "Circle" : "Circles";
            }

            if (tipo == FormaTipo.TrianguloEquilatero)
            {
                if (idioma == Castellano) return cantidad == 1 ? "Triángulo" : "Triángulos";
                return cantidad == 1 ? "Triangle" : "Triangles";
            }

            return string.Empty;
        }

        public decimal CalcularArea()
        {
            if (Tipo == FormaTipo.Cuadrado) return _lado * _lado;
            if (Tipo == FormaTipo.Circulo) return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
            if (Tipo == FormaTipo.TrianguloEquilatero) return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;

            throw new ArgumentOutOfRangeException("Forma desconocida");
        }

        public decimal CalcularPerimetro()
        {
            if (Tipo == FormaTipo.Cuadrado) return _lado * 4;
            if (Tipo == FormaTipo.Circulo) return (decimal)Math.PI * _lado;
            if (Tipo == FormaTipo.TrianguloEquilatero) return _lado * 3;

            throw new ArgumentOutOfRangeException("Forma desconocida");
        }
    }
}

*/
/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/
/*

 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */
