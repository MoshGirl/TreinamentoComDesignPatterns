using CursoDesignPatterns.MVC.Interface;
using CursoDesignPatterns.MVC.Service.Descontos;

namespace CursoDesignPatterns.MVC.Model
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento) 
        {
            IDescontoService d1 = new DescontoPorCincoItensService();
            IDescontoService d2 = new DescontoPorMaisDeQuinhentosReaisService();
            IDescontoService d3 = new SemDescontoService();

            d1.Proximo = d2;
            d2.Proximo = d3;

            return d1.Desconta(orcamento);
        }
    }
}