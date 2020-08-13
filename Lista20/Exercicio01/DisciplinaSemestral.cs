using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class DisciplinaSemestral: IDisciplina
    {
        private string nome;
        private int nota1, nota2, notaFinal;
        public DisciplinaSemestral(string nome, int n1, int n2,int nFinal)
        {
            if (nome != null) this.nome = nome;
            if (n1 >= 0) nota1 = n1;
            if (n2 >= 0) nota2 = n2;
            if (nFinal >= 0) notaFinal = nFinal;
        }
        
        public string GetNome()
        { return nome; }
        public int CalcMediaParcial()
        { return (2 * nota1 + 3 * nota2) / 5; }
        public int CalcMediaFinal()
        { return (2*CalcMediaParcial() + 3*notaFinal) / 5; }

    }
}
