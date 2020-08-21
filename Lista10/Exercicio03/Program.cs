using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Data ultimadata = new Data();

            Console.WriteLine("Digite o dia da data desejada");
            ultimadata.Dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o mês da data  desejada");
            ultimadata.Mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano da data  desejada");
            ultimadata.Ano = int.Parse(Console.ReadLine());

            Data datadesejada = ultimoDia();
            

            Console.WriteLine($"O Uitimo dia do mês de {datadesejada.mes} do ano de {ultimadata.Ano} é {ultimadata.Dia}");

            Console.ReadKey();
        }



        public struct Data
        {
            public int Dia;
            public int Mes;
            public int Ano;
        }

        public static Data UltimoDia(int mes, int ano)
        {

          Data calculadata = new Data();
        
            public string m;

         switch(mes){

            case 1:
            m = "janeiro";
            Break;
             case 2:
            m = "fevereiro";
            Break;
             case 3:
            m = "março";
            Break;
             case 4:
            m = "abril";
            Break;
             case 5:
            m = "maio";
            Break;
             case 6:
            m = "junho";
            Break;
             case 7:
            m = "julho";
            Break;
             case 8:
            m = "agosto";
            Break;
             case 9:
            m = "setembro";
            Break;

             case 10:
            m = "outubro";
            Break;

             case 11:
            m = "novembro";
            Break;
             case 12:
            m = "dezembro";
            Break;
            default:
            m="mes inválido"
            Break;

            }
                Dia.calculadata=dia;
                Mes.calculadata=mes;
                Ano.caluladata=ano;


                return calculadata;

           }




    }
}
