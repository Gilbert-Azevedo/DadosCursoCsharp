using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03a
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("informe nome da Playlist");
            string n = Console.ReadLine();
            
             Console.WriteLine("informe uma descrição para a Playlist");
            string descr = Console.ReadLine();
        

            Console.WriteLine("informe o tamanho da Playlist");
            int tamanho = int.Parse(Console.ReadLine());

            Playlist p = new Playlist(n, descr,tamanho);

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("informe os dados da música");
                Console.Write("Título : ");
                string tit = Console.ReadLine();
                Console.Write("Artista : ");
                string art = Console.ReadLine();
                Console.Write("Album: ");
                string alb = Console.ReadLine();
                Console.Write("Duracao: ");
                TimeSpan durac = TimeSpan.Parse(Console.ReadLine());
                
                Musica m = new Musica(tit,art,alb,durac);
                p.Inserir(m);
                           
             }
            foreach (Musica mx in p.Listar())
             Console.WriteLine(mx);

            Console.WriteLine($"Tempo total da Playlist: {p.TempoTotal()}");

            Console.ReadKey();
            
                    }
    }
}
