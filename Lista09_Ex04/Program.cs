using System;

namespace Lista09_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o Raio da Esfera");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine($"O volume da Esfera é :{VolumeEsfera(raio):00.00} m3");
            Console.ReadKey();

        }

        public static double VolumeEsfera(double r)
        {
            double volume = Math.PI * Math.Pow(r, 3);
            return volume;
        }
    }
}
