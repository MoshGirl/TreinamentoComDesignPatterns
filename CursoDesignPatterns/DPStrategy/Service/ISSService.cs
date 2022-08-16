namespace CursoDesignPatterns
{
    public class ISSService : IImpostoService
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}