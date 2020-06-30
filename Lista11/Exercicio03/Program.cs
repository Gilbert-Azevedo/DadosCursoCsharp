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
            Viagem trip = new Viagem();
            Console.WriteLine("Digite a distância percorrida em Km");
            trip.dist = double.Parse(Console.ReadLine());
            Console.WriteLine("informe a quantidade de total de horas:");
            trip.horas = double.Parse(Console.ReadLine());
            Console.WriteLine("informe a quantidade total de minutos:");
            trip.min = double.Parse(Console.ReadLine());


            Console.WriteLine($"A velocidade média da viagem foi de {trip.Velocidade():0.00} Km/h");
           
            Console.ReadKey();

        }
    }
}
