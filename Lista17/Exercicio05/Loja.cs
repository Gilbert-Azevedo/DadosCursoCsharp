using System;
using System.Collections.Generic;
using System.Dynamic;
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
            if (k < apps.Length)
                apps[k++] = app;
            else
            {
                if (k == apps.Length) Array.Resize(ref app, 2 * app.Length);
                apps[k++] = app;
            }
        }
        public void Excluir(Aplicativo app)
        {
            int i = 0;
            int j = 0;
            while ((app[i] != app) && (i < app.Length)) i++;
            app[i] = null;
            for (j = i; j < k; j++)
                app[j] = app[j + 1];

            Array.Resize(ref app, app.Length - 1);
            k--;
        }
        public Aplicativo[] Listar()
        {
            Aplicativo[] novosapps = new aplicativo[k];

            Array.Copy(apps, novosapps, k);

            return novosapps;

        }

        public Aplicativo[] Pesquisar(string cat)
        {
            int napps = 0;
            int j = 0;
            for (int i = 0; i < k; i++)
                if (apps[i].categoria == cat) napps++;

            Aplicativo[] listapesquisa = Aplicativo[napps];

            for (int i = 0; i < k; i++)
            {
                if (apps[i].categoria == cat)
                    listapesquisa[j++] = apps[i];

            }

          return listapesquisa;

        }





    }
}
