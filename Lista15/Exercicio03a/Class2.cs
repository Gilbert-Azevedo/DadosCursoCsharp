using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03a
{
    class Musica
    {
       private string titulo, artista, album;
        private DateTime dataInclusao;
        private TimeSpan duracao = new TimeSpan();

        public Musica(string titulo, string artista, string album, TimeSpan duracao)
        {
            this.titulo = titulo;
            this.artista = artista;
            this.album = album;
           this.duracao = duracao;


        }

        public override string ToString()
        {
            return $" Musica: { titulo } - Artista: {artista } - Descrição: {album} - Data de Inclusao {dataInclusao:dd/MM/yyyy}  - Duracao {duracao } ";
        }
        public void SetDataInclusao(DateTime d)
        {
            dataInclusao = d;
        }
        public TimeSpan GetDuracao()
        {
            return duracao;
        }

    }

}
