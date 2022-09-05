using CursoDesignPatterns.MVC.Model;

namespace CursoDesignPatterns.MVC.Interface
{
    public interface IDescontoService
    {
        double Desconta(Orcamento orcamento);
        IDescontoService Proximo { get; set; }
    }
}