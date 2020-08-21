using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Premio
    {
        private string cliente;
        private DateTime data = new DateTime();
        private object premio;

        public Premio(string c, DateTime d)
        {
            if (c != null) cliente = c;
            data = d;

        }
        
            public void SetPremio(object p)
            {
                premio=p;
            }
            public object GetPremio()
            {
               return premio;
            }

        public override string ToString()
        {
            return $" Nome do Cliente: {cliente}  - Data da compra:{data}  - Premio Escolhido: {premio} ";
        }
    }
}
