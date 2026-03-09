namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Cuadrado : FormaGeometrica
    {
        private readonly decimal _lado;

        public Cuadrado(decimal lado)
        {
            ValidarMayorACero(lado, nameof(lado));
            _lado = lado;
        }

        public override TipoForma Tipo
        {
            get { return TipoForma.Cuadrado; }
        }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }
    }
}
