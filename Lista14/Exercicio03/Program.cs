using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            string codB = "1234353.4544643.43425433424";
            DateTime dataemis = DateTime.Parse("01/07/2020") ;
            DateTime datavenc = dataemis.AddDays(15);
            DateTime datapagto  = DateTime.Now;
            Console.WriteLine("informe o valor do Boleto:");
            decimal vBoleto = decimal.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor a ser pago");
            decimal valorPg = decimal.Parse(Console.ReadLine());

            Boleto boletoapagar = new Boleto(codB, dataemis, datavenc, datapagto, vBoleto);
            boletoapagar.Pagar(valorPg);
           
            Console.WriteLine(boletoapagar.ToString());
            Console.ReadKey();

        }
    }
}
