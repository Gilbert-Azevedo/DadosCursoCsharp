using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Musica
    {
        private string titulo, artista, album;
        private DateTime dataInclusao;
        private TimeSpan duracao = new TimeSpan();

        public string Titulo {

            get { return titulo; }
            set { if (value != null) titulo = value; }
                   
        }
        public string Artista
        {
            get { return artista; }
            set { if (value != null) artista = value; }
        }
        public string Album
        {
            get { return album; }
            set { if (value != null) album = value; }
        }
        public TimeSpan Duracao
        {
            get { return duracao; }
            set { if (value != null) duracao = value; }
        }
        public DateTime DataInclusao
        {
            get { return DateTime.Now; }
        }
       

        public override string ToString()
        {
            return $" Musica: {Titulo } - Artista: {Artista } - Descrição: {Album} - Data de Inclusao {DataInclusao:dd/MM/yyyy}  - Duracao {Duracao} ";
        }
        public void SetDataInclusao(DateTime d)
        {
            dataInclusao = d;
        }
       
    }
}
