using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Data testedata = new Data();

            Console.WriteLine("Digite o dia da data a ser testada");
            testedata.Dia = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o mês da data a ser testada");
            testedata.Mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano da data a ser testada");
            testedata.Ano = int.Parse(Console.ReadLine());


            if (((testedata.Dia<=0)||(testedata.Dia >31)||((testedata.Dia > 28)&&(testedata.Mes ==2))||((testedata.Dia>30)&&((testedata.Mes == 4)||(testedata.Mes == 6)||(testedata.Mes == 9)||(testedata.Mes == 11)))))
             {
                Console.WriteLine("A data não é válida");
            }
            else
            {
                Console.WriteLine("A data não é válida");
            }
                       
            Console.ReadKey();
        }



        struct Data
        {
            public int Dia;
            public int Mes;
            public int Ano;
        }
    }
}
