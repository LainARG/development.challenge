using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Reporte;
using DevelopmentChallenge.Data.Classes.Reporte.Idiomas;
using NUnit.Framework;
using System;
using System.Collections.Generic;


namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", Reporte.Imprimir(new List<FormaGeometrica>(), new LocalizadorCastellano()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", Reporte.Imprimir(new List<FormaGeometrica>(), new LocalizadorIngles()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5)
            };

            var resumen = Reporte.Imprimir(cuadrados, new LocalizadorCastellano());
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 forma Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = Reporte.Imprimir(cuadrados, new LocalizadorIngles());
            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(3.12m),
                new TrianguloEquilatero(2.7m)
            };

            var resumen = Reporte.Imprimir(formas, new LocalizadorIngles());
            Assert.AreEqual("<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = Reporte.Imprimir(formas, new LocalizadorCastellano());
            Assert.AreEqual("<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var formas = new List<FormaGeometrica>
            {
                new Trapecio(10, 6, 4, 5, 5)
            };

            var resumen = Reporte.Imprimir(formas, new LocalizadorCastellano());
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 32 | Perimetro 26 <br/>TOTAL:<br/>1 forma Perimetro 26 Area 32", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new Trapecio(10, 6, 4, 5, 5)
            };

            var resumen = Reporte.Imprimir(formas, new LocalizadorIngles());
            Assert.AreEqual("<h1>Shapes report</h1>1 Trapezoid | Area 32 | Perimeter 26 <br/>TOTAL:<br/>1 shape Perimeter 26 Area 32", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Trapecio(10, 6, 4, 5, 5)
            };

            var resumen = Reporte.Imprimir(formas, new LocalizadorItaliano());
            Assert.AreEqual("<h1>Rapporto delle Forme</h1>1 Trapezio | Area 32 | Perimetro 26 <br/>TOTALE:<br/>1 forma Perimetro 26 Area 32", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapecios()
        {
            var formas = new List<FormaGeometrica>
            {
                new Trapecio(10, 6, 4, 5, 5),
                new Trapecio(8, 4, 3, 4, 4)
            };

            var resumen = Reporte.Imprimir(formas, new LocalizadorCastellano());
            Assert.AreEqual("<h1>Reporte de Formas</h1>2 Trapecios | Area 50 | Perimetro 46 <br/>TOTAL:<br/>2 formas Perimetro 46 Area 50", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapeciosEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new Trapecio(10, 6, 4, 5, 5),
                new Trapecio(8, 4, 3, 4, 4)
            };
            var resumen = Reporte.Imprimir(formas, new LocalizadorIngles());
            Assert.AreEqual("<h1>Shapes report</h1>2 Trapezoids | Area 50 | Perimeter 46 <br/>TOTAL:<br/>2 shapes Perimeter 46 Area 50", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapeciosEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Trapecio(10, 6, 4, 5, 5),
                new Trapecio(8, 4, 3, 4, 4)
            };

            var resumen = Reporte.Imprimir(formas, new LocalizadorItaliano());
            Assert.AreEqual("<h1>Rapporto delle Forme</h1>2 Trapezi | Area 50 | Perimetro 46 <br/>TOTALE:<br/>2 forme Perimetro 46 Area 50", resumen);
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void CuadradoLadoMenorOIgualACero(decimal lado)
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Cuadrado(lado));
            Assert.AreEqual("lado", ex.ParamName);
        }

        [TestCase(-2)]
        [TestCase(0)]
        public void CirculoDiametroMenorOIgualACero(decimal diametro)
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Circulo(diametro));
            Assert.AreEqual("diametro", ex.ParamName);
        }

        [TestCase(-3)]
        [TestCase(0)]
        public void TrianguloEquilateroLadoMenorOIgualACero(decimal lado)
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new TrianguloEquilatero(lado));
            Assert.AreEqual("lado", ex.ParamName);
        }

        [TestCase(0, 6, 4, 5, 5, "baseMayor")]
        [TestCase(-1, 6, 4, 5, 5, "baseMayor")]
        [TestCase(10, 0, 4, 5, 5, "baseMenor")]
        [TestCase(10, -2, 4, 5, 5, "baseMenor")]
        [TestCase(10, 6, 0, 5, 5, "altura")]
        [TestCase(10, 6, -3, 5, 5, "altura")]
        [TestCase(10, 6, 4, 0, 5, "ladoIzquierdo")]
        [TestCase(10, 6, 4, -4, 5, "ladoIzquierdo")]
        [TestCase(10, 6, 4, 5, 0, "ladoDerecho")]
        [TestCase(10, 6, 4, 5, -5, "ladoDerecho")]
        public void TrapecioParametrosMenoresOIgualesACero(decimal baseMayor, decimal baseMenor, decimal altura, decimal ladoIzquierdo, decimal ladoDerecho, string parametroEsperado)
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Trapecio(baseMayor, baseMenor, altura, ladoIzquierdo, ladoDerecho));
            Assert.AreEqual(parametroEsperado, ex.ParamName);
        }
    }
}
