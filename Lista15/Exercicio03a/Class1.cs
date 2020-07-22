using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercicio03a
{
    class Playlist
    {
        private string nome;
        private string descricao;
        private Musica[] musicas;
        private int k,tamanho;
      
        public Playlist(string nome, string descricao,int tamanho)
         {
            this.nome = nome;
            this.descricao = descricao;
            this.tamanho = tamanho;
            musicas = new Musica[tamanho];
         }
        public void Inserir(Musica m)
        {
            if (k == tamanho) Array.Resize(ref musicas, 2 * tamanho);
            musicas[k] = m;
            m.SetDataInclusao(DateTime.Now);
            k++;
                    
        }
        public Musica[] Listar()
        {
            Musica[] vetorMusicas = new Musica[k];
            Array.Copy(musicas,vetorMusicas, k);
            
            return vetorMusicas;
        }
        public TimeSpan TempoTotal()
        {
            TimeSpan somaTempo = new TimeSpan();
            foreach (Musica m in Listar())
                somaTempo += m.GetDuracao();
            return somaTempo;
        }

       // public override string ToString()
        //{
        //    return $" Playlist: {nome}  - Descrição: {descricao}  -  Musica: {ng()} -TempoTotal {TempoTotal()} ";
        //}



    }
}
