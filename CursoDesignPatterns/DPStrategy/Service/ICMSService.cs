namespace CursoDesignPatterns
{
    public class ICMSService : IImpostoService
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}