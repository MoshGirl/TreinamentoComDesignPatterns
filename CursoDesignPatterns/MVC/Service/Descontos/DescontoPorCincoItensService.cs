using CursoDesignPatterns.MVC.Interface;
using CursoDesignPatterns.MVC.Model;

namespace CursoDesignPatterns.MVC.Service.Descontos
{
    public class DescontoPorCincoItensService : IDescontoService
    {
        public IDescontoService Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}