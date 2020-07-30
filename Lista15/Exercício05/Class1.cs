using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício05
{
    class Empresa
    {
        private Cliente[] clientes;
        private int k=0;

        public  Empresa()
        {
            clientes = new Cliente[1];
        }

       
        public void Inserir(Cliente c)
        {
            Array.Resize(ref clientes,k+1);
            clientes[k] = c;
            k++;    
        }
        public Cliente[] Listar()
        {
            Cliente[] listaclentes = new Cliente[clientes.Length];
            Array.Copy(clientes, listaclentes, clientes.Length);
              return listaclentes;
        }


    }
}
