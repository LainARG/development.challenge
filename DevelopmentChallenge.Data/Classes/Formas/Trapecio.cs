namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;
        private readonly decimal _ladoIzquierdo;
        private readonly decimal _ladoDerecho;

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal ladoIzquierdo, decimal ladoDerecho)
        {
            ValidarMayorACero(baseMayor, nameof(baseMayor));
            ValidarMayorACero(baseMenor, nameof(baseMenor));
            ValidarMayorACero(altura, nameof(altura));
            ValidarMayorACero(ladoIzquierdo, nameof(ladoIzquierdo));
            ValidarMayorACero(ladoDerecho, nameof(ladoDerecho));
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
            _ladoIzquierdo = ladoIzquierdo;
            _ladoDerecho = ladoDerecho;
        }

        public override TipoForma Tipo
        {
            get { return TipoForma.Trapecio; }
        }

        public override decimal CalcularArea()
        {
            return ((_baseMayor + _baseMenor) / 2) * _altura;
        }

        public override decimal CalcularPerimetro()
        {
            return _baseMayor + _baseMenor + _ladoIzquierdo + _ladoDerecho;
        }
    }
}
