using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Circulo circ = new Circulo();
                Console.WriteLine("Digite o Raio do circulo em metros");
                circ.SetRaio(double.Parse(Console.ReadLine()));
                Console.WriteLine($"A Área do circulo é {circ.CalcArea():0.00} m2");
                Console.WriteLine($"O tamanho da circunferencia do circulo é {circ.CalcCircunferencia():0.00} m");
                Console.ReadKey();
            }
        }
    }
}
