using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            IMC paciente = new IMC();

            Console.WriteLine("Digite o peso (Massa) em Kg");
            paciente.Massa = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Altura em m");
           paciente.Altura = double.Parse(Console.ReadLine());

            paciente.Imc = paciente.Massa / (paciente.Altura * paciente.Altura);

            Console.WriteLine($"O Imc do paciente é: {paciente.Imc:0.00} kg/m2");
            Console.ReadKey();
        }


  
     struct IMC
    {
        public double Massa;
        public double Altura;
        public double Imc;


    }

}
}
