using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a Distancia percorrida em Km");
            double dist = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o peso da carga em kg");
            double pes = double.Parse(Console.ReadLine());

            Frete frt = new Frete(dist, pes);
            Console.WriteLine($"o valor do frete é : R$ {frt.CalcFrete():0.00} ");
            Console.WriteLine(frt.ToString());

            Console.WriteLine("Informe a nova Distancia percorrida em Km");
            dist = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o novo peso da carga em kg");
            pes = double.Parse(Console.ReadLine());
            frt.SetDistancia(dist);
            frt.SetPeso(pes);
            Console.WriteLine($"o novo valor do frete é : R$ {frt.CalcFrete():0.00} ");
            Console.WriteLine(frt.ToString());
            Console.ReadKey();
        }
    }
}
