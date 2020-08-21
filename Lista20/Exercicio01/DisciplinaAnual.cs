using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class DisciplinaAnual: IDisciplina 
    {
        private string nome;
        private int nota1, nota2, nota3, nota4, notaFinal;
        public DisciplinaAnual(string nome, int n1, int n2, int n3, int n4, int nFinal)
        {
            if (nome != null) this.nome = nome;
            if (n1 >= 0) nota1 = n1;
            if (n2 >= 0) nota2 = n2;
            if (n3 >= 0) nota3 = n3;
            if (n4 >= 0) nota4 = n4;
            if (nFinal >= 0) notaFinal = nFinal;
        }

        public string GetNome()
        { return nome;}
        public int CalcMediaParcial()
        { return  (2*nota1+2*nota2+3*nota3+3*nota4)/10; }
        public int CalcMediaFinal()
        { return (2*CalcMediaParcial() + 3*notaFinal)/5; }

    }
}
