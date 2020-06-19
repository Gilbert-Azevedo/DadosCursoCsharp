using System;

namespace Exercício10_Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
            string data = Console.ReadLine();
            string[] vdata = data.Split('/');
            int dia = int.Parse(vdata[0]);
            int mes = int.Parse(vdata[1]);
            int ano = int.Parse(vdata[2]);

            if (  ((dia < 1)||(dia> 31)||(mes < 1)||(mes> 12)||(ano < 1900)||(ano > 2100))||((dia > 28) && (mes == 2)) || ((dia == 31) && ((mes == 4) || (mes == 6) || (mes == 9) || (mes == 11))) )         {
                Console.WriteLine($"A data informada {dia:00}/{mes:00}/{ano} não é válida.");
            }
            else
            {
                Console.WriteLine($"A data informada {dia:00}/{mes:00}/{ano} é válida.");
            }
                   

            Console.ReadKey();

        }
    }
}
