using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_de_Datas
{
    class Datas
    {

        private DateTime datainicial = new DateTime();
        private DateTime dataatual = new DateTime();
        private DateTime datafutura = new DateTime();

       
        public void SetDatas(DateTime di, DateTime da,DateTime df)
        {
            datainicial = di;
            dataatual = da;
            datafutura = df;
        }

        public void GetDatas(out DateTime di, out DateTime da, out DateTime df)
        {
           di= datainicial;
           da = dataatual;
           df= datafutura;
        }

        public TimeSpan Intervalos(DateTime di, DateTime df)
        {

            TimeSpan diferenca = new TimeSpan();
            diferenca = df - di;
            return diferenca;
        }

     }
}
