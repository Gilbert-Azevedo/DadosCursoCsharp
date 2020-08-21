using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Disciplina
    {
        private string nome;
        private int nota1, nota2, nota3, nota4, notaFinal;
        public void SetNome(string s){
            if(s!=null) nome=s; 
            }
       public void SetNota1(int v){
            if (v > 0) nota1=v; 
            }
        public void SetNota2(int v)
        {
            if (v > 0) nota2 = v;
        }
        public void SetNota3(int v)
        {
            if (v > 0) nota3 = v;
        }
        public void SetNota4(int v)
        {
            if (v > 0) nota4 = v;
        }
        public void SetNotaFinal(int v)
        {
            if (v > 0) notaFinal = v;
        }
        public string GetNome()
        {
            return nome;
        }
        public int GetNota1()
        {
            return nota1;
        }
        public int GetNota2()
        {
            return nota2;
        }
        public int GetNota3()
        {
            return nota3;
        }
        public int GetNota4()
        {
            return nota4;
        }
        public int GetNotaFinal()
        {
         return notaFinal;
        }

        public int CalcMediaParcial()
        {
            int mediaparcial = (2 * GetNota1() + 2 * GetNota2() + 3 * GetNota3() + 3 * GetNota4()) / 10;
            return mediaparcial;
        }
        public int CalcMediaFinal()
        {
            int mediafinal = (CalcMediaParcial() + GetNotaFinal()) / 2;
            return mediafinal;
        }

    }
}
