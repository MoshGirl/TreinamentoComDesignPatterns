using CursoDesignPatterns.MVC.Interface;
using CursoDesignPatterns.MVC.Model;

namespace CursoDesignPatterns.MVC.Service.Impostos
{
    public class ISSService : IImpostoService
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}