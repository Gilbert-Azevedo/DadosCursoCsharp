using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {

           Entrada ingresso = new Entrada();

            Console.WriteLine("Digite o dia desejado");
            string dfilme = Console.ReadLine();

            Console.WriteLine("Digite o horário desejado no formato HH:MM");
            string[] horafilme = Console.ReadLine().Split(':');
            int hfilm = int.Parse(horafilme[0]);
            int mfilm = int.Parse(horafilme[1]);
            ingresso.SetDia(dfilme);
            ingresso.SetHorario(hfilm, mfilm);

            Console.WriteLine($"{hfilm:00}:{mfilm:00}");
            Console.WriteLine($"O valor do Ingresso é : R$ {ingresso.ValorIngresso():00.00} ");

            Console.ReadKey();
        }
    }
}
