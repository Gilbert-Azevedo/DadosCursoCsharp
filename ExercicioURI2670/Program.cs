using System;

namespace ExercicioURI2670
{
    class Program
    {
        static void Main(string[] args)
        {
            int somaandar12 = 0, somaandar13 = 0, somaandar21 = 0, somaandar23 = 0, somaandar31 = 0, somaandar32 = 0;
            int totalandar1 = 0, totalandar2 = 0, totalandar3 = 0;

            int nfunc1 = int.Parse(Console.ReadLine());
            int nfunc2 = int.Parse(Console.ReadLine());
            int nfunc3 = int.Parse(Console.ReadLine());

            // Analise para a máquina no primeiro andar

            for (int i = 1; i<= nfunc2; i++)
            {
                somaandar21 = somaandar21 + 2;
            }
            for (int j = 1; j <= nfunc3; j++)
            {
               somaandar31 = somaandar31 + 4;
            }

            totalandar1 = somaandar21 + somaandar31;

           // Analise para a máquina no segundo andar
           for (int k = 1; k <= nfunc1; k++)
            {
                somaandar12 = somaandar12 + 2;
                
            }

            for (int m = 1; m <= nfunc3; m++)
            {
                somaandar32 = somaandar32 + 2;
            }
            totalandar2 = somaandar12 + somaandar32;

            // Analise para a máquina no terceiro andar
            for (int n = 1; n <= nfunc1; n++)
            {
                somaandar13 = somaandar13 + 4;

            }

            for (int p = 1; p <= nfunc2; p++)
            {
                somaandar23 = somaandar23 + 2;
            }
            totalandar3 = somaandar13 + somaandar23;

            int melhorandar = totalandar1;

            if (totalandar2 <= melhorandar) 
            {
                melhorandar = totalandar2;
            }
            if (totalandar3 <= melhorandar)
            {
                melhorandar = totalandar3;
            }


           Console.WriteLine(melhorandar);

            Console.ReadKey();
                      
           
        }
    }
}
