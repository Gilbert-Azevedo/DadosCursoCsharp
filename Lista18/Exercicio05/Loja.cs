using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Loja
    {
        private Aplicativo[] apps = new Aplicativo[10];
        private int k;
        public string Nome { get; set; }
        public int Qtd { get; set; }

        public void Inserir(Aplicativo app)
        {
            if (k > apps.Length) Array.Resize(ref apps, 2 * apps.Length);
                apps[k++] = app;
         }
        public void Excluir(Aplicativo app)
        {
            int i = 0;
            int j = 0;
            while ((apps[i] != app) && (i < apps.Length)) i++;
            apps[i] = null;
            for (j = i; j < k; j++)
                apps[j] = apps[j + 1];

            Array.Resize(ref apps, apps.Length - 1);
            k--;
        }
        public Aplicativo[] Listar()
        {
            Aplicativo[] novosapps = new Aplicativo[k];

            Array.Copy(apps, novosapps, k);

            return novosapps;

        }
  

        /* public Aplicativo[] Pesquisar(string cat)
         {
             int napps = 0;
             int j = 0;
             for (int i = 0; i < k; i++)
                 if (apps[i].Categoria == cat) napps++;

             Aplicativo[] listapesquisa = Aplicativo[napps];

             for (int i = 0; i < k; i++)
             {
                 if (apps[i].Categoria == cat)
                     listapesquisa[j++] = apps[i];

             }
             return listapesquisa;

         }
      */



    }
}
