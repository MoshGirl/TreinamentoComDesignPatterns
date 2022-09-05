﻿using CursoDesignPatterns.MVC.Interface;
using CursoDesignPatterns.MVC.Model;

namespace CursoDesignPatterns.MVC.Service.Descontos
{
    public class DescontoPorMaisDeQuinhentosReaisService : IDescontoService
    {
        public IDescontoService Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500.0)
            {
                return orcamento.Valor * 0.07;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}