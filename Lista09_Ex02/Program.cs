using System;

namespace Lista09_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
           
               Console.WriteLine("Digite o Raio do Círculo");
               double raio = double.Parse(Console.ReadLine());
               Console.WriteLine($"A Área do circulo é :{AreaCirculo(raio):00.00} m2");
               Console.ReadKey();

             }
        
        public static double AreaCirculo(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);
            return area;
        }

    }
}
