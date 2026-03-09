using System;


namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private readonly decimal _lado;

        public TrianguloEquilatero(decimal lado)
        {
            ValidarMayorACero(lado, nameof(lado));
            _lado = lado;
        }

        public override TipoForma Tipo
        {
            get { return TipoForma.TrianguloEquilatero; }
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }
    }
}
