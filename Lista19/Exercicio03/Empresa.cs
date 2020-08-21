using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Empresa
    {
        private Cliente[] clientes = new Cliente[10];
        int k = 0;
        public void Inserir(Cliente c)
        {
            if (k < clientes.Length) clientes[k++] = c;
            else
                Array.Resize(ref clientes, 2 * clientes.Length);

        }
        public Cliente[] Listar()
        {
            Cliente[] listaclientes = new Cliente[k];
            Array.Copy(clientes, listaclientes, k);
            return listaclientes;
        }
    }
}
