using CursoDesignPatterns.MVC.Interface;
using CursoDesignPatterns.MVC.Model;

namespace CursoDesignPatterns.MVC.Service.Descontos
{
    public class SemDescontoService : IDescontoService
    {
        public IDescontoService Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}