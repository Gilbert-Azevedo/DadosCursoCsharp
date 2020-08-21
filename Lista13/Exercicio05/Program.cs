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
            int dia, mes, ano;

            Console.WriteLine("Digite o dia para teste de Data");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mes para teste de Data");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano para teste de Data");
            ano = int.Parse(Console.ReadLine());

            Data testedata = new Data(dia, mes, ano);
            Console.WriteLine(testedata.ToString());


            Console.WriteLine("Digite um outro dia para teste de Data");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um outro mes para teste de Data");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um outroano para teste de Data");
            ano = int.Parse(Console.ReadLine());

            testedata.SetData(dia,mes,ano);

            Console.WriteLine(testedata.ToString());

            Console.ReadKey();

        }
    }
}
