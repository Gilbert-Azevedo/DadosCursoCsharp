using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício05
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string nomec1 = "Alvaro    ";
            string cpfc1 = "79173497487";
            decimal limitec1 = 100000;
           

            string nomec2 = "Alessandra";
            string cpfc2 = "43474443434";
            decimal limitec2 = 150000;

           // numclientes = 5;


            Empresa novaEmpresa = new Empresa();
            
            Cliente c1 = new Cliente(nomec1, cpfc1, limitec1);
            novaEmpresa.Inserir(c1);
          


            Cliente c2 = new Cliente(nomec2, cpfc2, limitec2);
            novaEmpresa.Inserir(c2);

            
                   

               Cliente c3 = new Cliente("Eduardo   ", "65334249745", 150000);
               novaEmpresa.Inserir(c3);
               Cliente c4 = new Cliente("Gilbert   ", "37746549743", 200000);
               novaEmpresa.Inserir(c4);
               Cliente c5 = new Cliente("Adriana   ", "56533537758", 140000);
               novaEmpresa.Inserir(c5);

            c1.SetSocio(c2);
            
            c3.SetSocio(c4);
            
            c5.SetSocio(c4);


            Console.WriteLine("Lista de clientes");

            foreach (Cliente listatodos in novaEmpresa.Listar())
            {
                Console.WriteLine(listatodos.ToString());
            }


            Console.WriteLine(" ");

            Console.ReadKey();
                      

        }
    }
}
