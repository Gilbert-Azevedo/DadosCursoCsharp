using System;

namespace Exercicio06_lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Base e a Altura de um Retângulo");
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = b * h;
            double perim = 2*b + 2 * h;
            double diag = Math.Sqrt(b * b + h * h);
            Console.WriteLine($"Area = {area} - Perimetro = {perim} - Diagonal = {diag}");
            Console.ReadKey();

        }
    }
}
