using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_de_Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataini = new DateTime();
            DateTime dataatual = new DateTime();
            DateTime datafutura = new DateTime();
            Datas testedatas = new Datas();

            Console.WriteLine("Digite a data inicial desejada no formato dd/MM/aaaa");
            dataini = DateTime.Parse(Console.ReadLine());
            
            dataatual = DateTime.Today;
                     
            datafutura = DateTime.Today;

            testedatas.SetDatas(dataini, dataatual, datafutura);

            int anos = int.Parse(testedatas.Intervalos(dataini, dataatual).Days.ToString());
            anos = anos / 365;
            Console.WriteLine($" Você viveu {anos} anos");

            Console.WriteLine("Digite a data de posse no trabalho no formato dd/MM/aaaa");
            dataini = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data que irá se aposentar no formato dd/MM/aaaa");
            datafutura = DateTime.Parse(Console.ReadLine());

            testedatas.SetDatas(dataini, dataatual, datafutura);

            anos = int.Parse(testedatas.Intervalos(dataini, dataatual).Days.ToString());
            anos = anos / 365;
            
            Console.WriteLine($" Você trabalhou {anos} anos");

            anos = int.Parse(testedatas.Intervalos(dataatual, datafutura).Days.ToString());
            anos = anos / 365;

            Console.WriteLine($" Você ainda trabalhara {anos} anos");



            Console.ReadKey();



        }
    }
}
