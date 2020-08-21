using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Estagio
    {
       private string estagiario,empresa;
        private DateTime dataInicio = new DateTime();
        private DateTime dataCancelamento = new DateTime();
        private DateTime dataFim = new DateTime();
        private int situacao;
        public Estagio(string est, string emp)
        {
            if (est != null) estagiario = est;
            if (emp != null) empresa = emp;
        }
        public bool Iniciar(DateTime data)
        {
            bool inicio = true;
            dataInicio = data;

            return inicio;
        }

        public bool Cancelar(DateTime data)
        {
            bool cancela = true;
            dataCancelamento = data;

            return cancela;
        }

        public bool Finalizar(DateTime data)
        {
            bool fimEstagio = true;
            dataFim = data;

            return fimEstagio;
        }
        public TimeSpan TEmpoEstágio()
         {
            TimeSpan tempoEst = new TimeSpan();

            if (Iniciar(dataInicio))

            {
                tempoEst = dataInicio - DateTime.Now;
                 
            }




            return tempoEst;


         } 


        public override string ToString()
        {
            return $" Nome do Estagiário: {estagiario}  " ;
        }

               [Flags]
        public enum SituacaoEstagio
        {
            Cadastrado = 1, Iniciado = 2, Cancelado = 3, Finalizado =0
        }


    }
}
