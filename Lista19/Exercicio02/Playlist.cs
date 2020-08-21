using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Playlist
    {
        private string nome;
        private string descricao;
        private Musica[] musicas=new Musica[10];
        private int k;

        public string Nome
        {
            get { return nome;}
            set { this.nome = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { this.descricao = value; }
        }
        
        public void Inserir(Musica m)
        {
            if (k > musicas.Length) Array.Resize(ref musicas, 2*musicas.Length);
            m.SetDataInclusao(DateTime.Now);
            musicas[k++] = m;
        }
        public Musica[] Listar()
        {
            Musica[] vetorMusicas = new Musica[k];
            Array.Copy(musicas, vetorMusicas, k);

            return vetorMusicas;
        }
        public TimeSpan TempoTotal()
        {
            TimeSpan somaTempo = new TimeSpan();
          Musica[] mus = Listar();
            
            for (int i = 0; i < mus.Length; i++)
            {
            
                somaTempo += mus[i].Duracao;
            }

            return somaTempo;
        }
    }
}
