using System;


namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Circulo : FormaGeometrica
    {
        private readonly decimal _diametro;

        public Circulo(decimal diametro)
        {
            ValidarMayorACero(diametro, nameof(diametro));
            _diametro = diametro;
        }

        public override TipoForma Tipo
        {
            get { return TipoForma.Circulo; }
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_diametro / 2) * (_diametro / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _diametro;
        }
    }
}
