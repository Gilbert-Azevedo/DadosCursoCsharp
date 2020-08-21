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
            Disciplina disc = new Disciplina();

            Console.WriteLine("Digite o Nome da Disciplina");
            disc.SetNome(Console.ReadLine());
            Console.WriteLine("Digite as quatro notas dos quatro bimestres");
            disc.SetNota1(int.Parse(Console.ReadLine()));
            disc.SetNota2(int.Parse(Console.ReadLine()));
            disc.SetNota3(int.Parse(Console.ReadLine()));
            disc.SetNota4(int.Parse(Console.ReadLine()));

            int mparcial = disc.CalcMediaParcial();
            Console.WriteLine($"Média Parcial = {mparcial}");

            if (mparcial >= 60)
            {
                Console.WriteLine($"Aprovado na disciplina {disc.GetNome()}");
            }
            else
            {
                Console.WriteLine("O aluno deve fazer prova final");
                Console.WriteLine("Digite a nota da prova final");
                
                disc.SetNotaFinal(int.Parse(Console.ReadLine()));
                
                int mfinal = disc.CalcMediaFinal();

                Console.WriteLine($"Média Final = {mfinal}");
                if (mfinal >= 60)
                {
                    Console.WriteLine($"Aprovado na disciplina {disc.GetNome()}");
                }
                else
                {
                    Console.WriteLine($"Reprovado na disciplina {disc.GetNome()}");
                }



            }

            Console.ReadKey();
        }
    }
}
