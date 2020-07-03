using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os coeficientes da Equação de 2° Grau");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Equacao eq = new Equacao(a,b,c);


            Console.WriteLine($"Delta = {eq.Delta()}");
            Console.WriteLine(eq.ToString());


          
           Console.WriteLine("Informe novos coeficientes para a Equação de 2° Grau");

           a = double.Parse(Console.ReadLine());
           b = double.Parse(Console.ReadLine());
           c = double.Parse(Console.ReadLine());

            eq.SetABC(a, b, c);
            Console.WriteLine($"Delta = {eq.Delta()}");
            Console.WriteLine(eq.ToString());

                      
            
            Console.ReadKey();
           }
    }
}
