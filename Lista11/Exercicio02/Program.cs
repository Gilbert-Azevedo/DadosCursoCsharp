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
            disc.nome = Console.ReadLine();
            Console.WriteLine("Digite as quatro notas dos quatro bimestres");
            disc.nota1 = double.Parse(Console.ReadLine());
            disc.nota2 = double.Parse(Console.ReadLine());
            disc.nota3 = double.Parse(Console.ReadLine());
            disc.nota4 = double.Parse(Console.ReadLine());

            double mparcial = disc.MediaParcial();
            Console.WriteLine($"Média Parcial = {mparcial}");

            if (mparcial >= 60)
            {
                Console.WriteLine($"Aprovado na disciplina {disc.nome}");
            }
            else
            {
                Console.WriteLine("O aluno deve fazer prova final");
                Console.WriteLine("Digite a nota da prova final");
                disc.notafinal = double.Parse(Console.ReadLine());
                double mfinal = disc.MediaFinal();
                Console.WriteLine($"Média Final = {mfinal}");
                if (mfinal >= 60)
                {
                    Console.WriteLine($"Aprovado na disciplina {disc.nome}");
                }
                else
                {
                    Console.WriteLine($"Reprovado na disciplina {disc.nome}");
                }



            }


            Console.ReadKey();

        }
    }
}
