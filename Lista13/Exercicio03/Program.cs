using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o valor do numero inteiro a ser convertido");
            int numero = int.Parse(Console.ReadLine());
            Conversor conv = new Conversor(numero);
            Console.WriteLine(conv.ToString());
            Console.WriteLine("Informe outro numero inteiro a ser convertido");
            numero = int.Parse(Console.ReadLine());
            conv.SetNum(numero);
            Console.WriteLine(conv.ToString());


            Console.ReadKey();
        }
    }
}
