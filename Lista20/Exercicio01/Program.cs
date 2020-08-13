using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            DisciplinaAnual dAnual = new DisciplinaAnual("Matematica", 20, 30, 40, 40, 50);
            DisciplinaSemestral dSemestral = new DisciplinaSemestral("Eletronica", 20, 50, 80);

            int mediaparcial  = dAnual.CalcMediaParcial();
            if (mediaparcial >= 60) Console.WriteLine($"Aprovado na disciplina de {dAnual.GetNome()}");
            else
            {
                if (mediaparcial >= 20)
                {
                    Console.WriteLine($"Ficou em Provafinal na disciplina de {dAnual.GetNome()}");
                    int mediaFinal = dAnual.CalcMediaFinal();
                    if (mediaFinal >= 50) Console.WriteLine($"Aprovado na disciplina de {dAnual.GetNome()}");
                    else Console.WriteLine($"Reprovado na disciplina de {dAnual.GetNome()}");

                }
                else
                {
                    Console.WriteLine($"Reprovado na disciplina de {dAnual.GetNome()}");
                }



            }

            Console.ReadKey();

            mediaparcial = dSemestral.CalcMediaParcial();
            if (mediaparcial >= 60) Console.WriteLine($"Aprovado na disciplina de {dSemestral.GetNome()}");
            else
            {
                if (mediaparcial >= 20)
                {
                    Console.WriteLine($"Ficou em Provafinal na disciplina de {dSemestral.GetNome()}");
                 
                    int mediaFinal = dSemestral.CalcMediaFinal();
                    
                    if (mediaFinal >= 50) Console.WriteLine($"Aprovado na disciplina de {dSemestral.GetNome()}");
                    
                    else Console.WriteLine($"Reprovado na disciplina de {dSemestral.GetNome()}");

                }
                else
                {
                    Console.WriteLine($"Reprovado na disciplina de {dSemestral.GetNome()}");
                }



            }
            Console.ReadKey();
        }

    }
}
