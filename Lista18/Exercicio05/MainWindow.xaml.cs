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

namespace Exercicio05
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        Loja novaloja = new Loja();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Inserir_Click(object sender, RoutedEventArgs e)
        {
            Aplicativo novo = new Aplicativo();
            novo.Nome = txtNome.Text;
            novo.Categoria = txtCateg.Text;
            novo.Preco = txtPreco.Text;
            txtCurt.Text = novo.Curtidas.ToString();
            novaloja.Inserir(novo);
           Listapps.ItemsSource = novaloja.Listar();
        }

        private void Excluir_Click(object sender, RoutedEventArgs e)
        {
            if (Listapps.SelectedItem == null)
                MessageBox.Show("Nenhum Aplicativo Selecionado!");
            else
            {
                Aplicativo app = (Aplicativo)Listapps.SelectedItem;
                novaloja.Excluir(app);
                Listapps.ItemsSource = novaloja.Listar();
            }
        }

        private void Pesquisar_Click(object sender, RoutedEventArgs e)
        {
            string categ = txtCategPesq.Text;
            if (categ == "")
                MessageBox.Show("Nenhuma Categoria informada!");
            else
            {
               Listapps.ItemsSource = novaloja.Pesquisar(categ);
            }

        }

        private void Curtir_Click(object sender, RoutedEventArgs e)
        {

            if (Listapps.SelectedItem == null)
                MessageBox.Show("Nenhum Aplicativo Selecionado!");
            else
            {
                Aplicativo app = (Aplicativo)Listapps.SelectedItem;
                txtCurt.Text = app.Curtidas.ToString();
                app.Curtir();
                txtCurt.Text = app.Curtidas.ToString();
                Listapps.ItemsSource = novaloja.Listar();
            }
        }
               
        private void Listar_Click(object sender, RoutedEventArgs e)
        {
           Listapps.ItemsSource = novaloja.Listar();
        }

        private void Listapps_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Listapps.SelectedItem != null)
            {
                Aplicativo app = (Aplicativo)Listapps.SelectedItem;
                txtNome.Text = app.Nome;
                txtCateg.Text = app.Categoria;
                txtPreco.Text = app.Preco;
                txtCurt.Text = app.Curtidas.ToString();
            }
        }
    }
}
