using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Entrada
    {
        private string dia;
        private int hora, min;


        public void SetDia(String d)
        {
            if ((d != null) || (d == "Segunda") || (d == "Terca") || (d == "Quarta") || (d == "Quinta") || (d == "Sexta") || (d == "Sabado") || (d == "Domingo"))
            {
                dia = d;
            }
        }

        public void SetHorario(int h, int m)
        {
            if ((h >= 0) && (h <= 23))
            {
                hora = h;
            }
            if ((m >= 0) && (m <= 59))
            {
                min = m;
            }
        }

        public string GetDia()
        {
            return dia;
        }

        public int GetHora()
        {
            return hora;
        }

        public int GetMin()
        {
            return min;
        }

        public double ValorIngresso()
        {
            double valorbase, valoringresso=0;

            if ((dia == "Segunda") || (dia == "Terca") || (dia == "Quinta"))
            {

                valorbase = 16;

                if (hora > 17)
                {
                    valoringresso = valorbase + (valorbase / 2);
                }
                else
                {
                    valoringresso = valorbase;
                }
            }

            if (dia == "Quarta")
            {
                valoringresso = 8;
            }


            if ((dia == "Sexta") || (dia == "Sabado") || (dia == "Domingo"))
            {
                valorbase = 20;

                if (hora > 17)
                {
                    valoringresso = valorbase + (valorbase / 2);
                }
                else
                {
                    valoringresso = valorbase;
                }
                
            }

            return valoringresso;
        }
    }
}
