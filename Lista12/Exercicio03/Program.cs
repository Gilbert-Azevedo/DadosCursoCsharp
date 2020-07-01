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
            {
                double horas, min;
                Viagem trip = new Viagem();
                Console.WriteLine("Digite a distância percorrida em Km");
                trip.SetDistancia(double.Parse(Console.ReadLine()));
                Console.WriteLine("informe a quantidade de total de horas:");
                horas = double.Parse(Console.ReadLine());
                Console.WriteLine("informe a quantidade total de minutos:");
                min = double.Parse(Console.ReadLine());

                double tempototal = horas + min / 60;
                trip.SetTempo(tempototal);

                Console.WriteLine($"A velocidade média da viagem foi de {trip.VelocidadeMedia():0.00} Km/h");

                Console.ReadKey();

            }
        }
    }
}
