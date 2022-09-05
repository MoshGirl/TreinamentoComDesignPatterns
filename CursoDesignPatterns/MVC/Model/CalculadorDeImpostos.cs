using CursoDesignPatterns.MVC.Interface;
using System;

namespace CursoDesignPatterns.MVC.Model
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImpostoService imposto)
        {
            double calculo = imposto.Calcula(orcamento);
            Console.WriteLine(calculo);
        }
    }
}