using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {

            Frete novofrete = new Frete(3000, 500);
            Console.WriteLine(novofrete.ToString());
            Console.ReadKey();

        }
    }
}
