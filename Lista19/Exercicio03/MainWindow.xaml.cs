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

namespace Exercicio03
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private Empresa novaempresa = new Empresa();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NovoCliente_Click(object sender, RoutedEventArgs e)
        {
            novaempresa.Inserir(new Cliente("Alvaro", "797232542", 1000));
            novaempresa.Inserir(new Cliente("Alessandra","0303832", 2000));
            novaempresa.Inserir(new Cliente("Gilbert", "03878432", 3000));
            novaempresa.Inserir(new Cliente("Eduardo", "0385432", 4000));

            Listar_Click(sender, e);

        }

        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            list.ItemsSource = null;
            list.ItemsSource = novaempresa.Listar();
        }

        private void Associar_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItems.Count == 2)
            {
                Cliente x = (Cliente)list.SelectedItems[0];
                Cliente y = (Cliente)list.SelectedItems[1];
                x.SetSocio(y);
                Listar_Click(sender, e);
            }
            else
                MessageBox.Show("Selecione 2 Clientes para realizar a sociedade!");
        }

        private void Novo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
