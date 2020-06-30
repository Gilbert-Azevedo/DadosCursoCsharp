using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Disciplina
    {
        public string nome;
        public double nota1, nota2, nota3, nota4,notafinal, mediaparc, mediaf;
        public double MediaParcial()
        {
            mediaparc = (2 * nota1 + 2 * nota2 + 3 * nota3 + 3 * nota4) / 10;
            return mediaparc;
        }
        public double MediaFinal()
        {
            mediaf = (mediaparc + notafinal) /2;
            return mediaf;

        }

    }
}
