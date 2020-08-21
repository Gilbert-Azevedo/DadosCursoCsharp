using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circ = new Circulo();
            Console.WriteLine("Digite o Raio do circulo em metros");
            circ.r = double.Parse(Console.ReadLine());
            Console.WriteLine($"A Área do circulo é {circ.CalcAreaCirculo():0.00} m2");
            Console.WriteLine($"O tamanho da circunferencia do circulo é {circ.CalcCircunfCirculo():0.00} m");
            Console.ReadKey();
        }
    }
}
