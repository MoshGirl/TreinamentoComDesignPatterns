using CursoDesignPatterns.MVC.Interface;
using CursoDesignPatterns.MVC.Model;
using CursoDesignPatterns.MVC.Service.Impostos;
using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //DESIGN PATTERN STRATEGY

            //IImpostoService iss = new ISSService();
            //IImpostoService icms = new ICMSService();

            //Orcamento orcamento = new Orcamento(500.0);

            //CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            //calculador.RealizaCalculo(orcamento, iss);
            //calculador.RealizaCalculo(orcamento, icms);

            //DESIGN PATTERN CHAIN OF RESPONSIBILITY

            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(50);
            orcamento.AdicionaItem(new Item("Caneta", 30));
            orcamento.AdicionaItem(new Item("Lapis", 20));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);

            Console.ReadKey();
        }
    }
}