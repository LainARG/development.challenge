using DevelopmentChallenge.Data.Classes.Formas;

namespace DevelopmentChallenge.Data.Classes.Reporte
{
    public interface ILocalizador
    {
        string ListaVacia { get; }
        string Titulo { get; }
        string Total { get; }
        string Perimetro { get; }
        string Area { get; }

        string Formas(int cantidad);
        string NombreForma(TipoForma tipo, int cantidad);
    }
}
