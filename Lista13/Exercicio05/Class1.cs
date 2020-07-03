using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Data
    {
        private int dia, mes, ano;
        public Data(int dia, int mes, int ano)
        {
            if ((dia > 0) && (dia < 31)) this.dia = dia;
            if ((mes > 0) && (mes <=12)) this.mes = mes;
            if ((ano > 1900) && (ano <= 2100)) this.ano = ano;

        }
        public Data(string data)
       {
            string[] dataint = data.Split('/');
            int d = int.Parse(dataint[0]);
            int m = int.Parse(dataint[1]);
            int a = int.Parse(dataint[2]);
            if ((d > 0) && (d < 31)) dia = d;
            if ((m > 0) && (m <= 12)) mes = m;
            if ((a > 1900) && (a <= 2100)) ano = a;


        }
        public void SetData(int dia, int mes, int ano)
        {
            if ((dia > 0) && (dia < 31)) this.dia = dia;
            if ((mes > 0) && (mes <= 12)) this.mes = mes;
            if ((ano > 1900) && (ano <= 2100)) this.ano = ano;

        }
        public int GetDia()
        {
            return dia;
        }
        public int GetMes()
        {
            return mes;
        }
        public int GetAno()
        {
            return ano;
        }
        public override string ToString()
        {
            return $"{dia:00}/{mes:00}/{ano:0000}";
        }


    }
}
