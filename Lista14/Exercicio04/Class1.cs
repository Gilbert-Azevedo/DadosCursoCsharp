using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Estagiario
    {
        private string nome, cpf, telefone;
        private Dias dias;
        private Turno turno;



        public Estagiario(string n, string c, string t)
        {
            if (n != null) nome = n;
            if (c != null) cpf = c;
            if (t != null) telefone = t;

        }
        public void SetDias(Dias d){

            dias = d;
           }
        public void SetTurnos(Turno t)
        {
           turno = t;
        }

        public Dias GetDias()
        {
                     
            return dias;
        }

        public Turno  GetTurno()
        {
           return turno;
        }

        public override string ToString()
        {
            return $" Nome do Estagiário: {nome} - CPF: {cpf} - Telefone: {telefone} \n" +
                   $" - Dias de Trabalho:  {dias}  - Turno de Trabalho:  {turno} " ;
        }

        [Flags]
        public enum Dias {

            nenhum =0, segunda = 2, terca = 4, quarta = 8, quinta = 16, sexta = 32
        }
        [Flags]
        public enum Turno
        {
            matutino = 1, vespertino = 2, noturno = 3
        }

    }
}
