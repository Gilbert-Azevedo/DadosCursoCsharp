using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercicio01
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private Bingo novoSorteio = new Bingo();
        private int numsorteado;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Iniciar_Click(object sender, RoutedEventArgs e)
        {
            novoSorteio.Iniciar(int.Parse(txtNumBolas.Text));
        }

        private void Sortear_Click(object sender, RoutedEventArgs e)
        {
            numsorteado = novoSorteio.Proximo();
            txtResultado.Text = numsorteado.ToString();

            int[] numSorteados = novoSorteio.Sorteados();

            TxtSorteados.Text = "";

            foreach (int i in numSorteados)
            {
                TxtSorteados.Text = i.ToString();
            }


            /*
            for (int i = 0; i < numSorteados.Length; i++)
            {
                TxtSorteados.Text = novoSorteio.ToString();
            }
                           */

        }

        

       
    }
}
