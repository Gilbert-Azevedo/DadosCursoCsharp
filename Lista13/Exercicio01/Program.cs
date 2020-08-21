using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor da base e da altura do retângulo");
            int bas = int.Parse(Console.ReadLine());
            int alt = int.Parse(Console.ReadLine());

            Retangulo r1 = new Retangulo(bas,alt);
            Console.WriteLine($"O valor da area é: {r1.CalcArea():0.00} m2");
            Console.WriteLine($"O valor da diagonal é: {r1.CalcDiagonal():0.00} m");
            Console.WriteLine(r1.ToString());

            Console.WriteLine("Informe o novo valor da base e da altura do retângulo");
            bas = int.Parse(Console.ReadLine());
            alt = int.Parse(Console.ReadLine());
            r1.SetBase(bas);
            r1.SetAltura(alt);

            Console.WriteLine($"O valor da area é: {r1.CalcArea():0.00} m2");
            Console.WriteLine($"O valor da diagonal é: {r1.CalcDiagonal():0.00} m");
            Console.WriteLine(r1.ToString());


            Console.ReadKey();
        }
    }
}
