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

namespace Exercicio02
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private Playlist novaplay = new Playlist();  

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NovaPlayList_Click(object sender, RoutedEventArgs e)
        {
            novaplay.Nome = txtNome.Text;
            novaplay.Descricao = txtDescricao.Text;
        }

        private void Inserir_Click(object sender, RoutedEventArgs e)
        {
            Musica novamusica = new Musica();
            novamusica.Titulo = txtTitulo.Text;
            novamusica.Artista = txtArtista.Text;
            novamusica.Album = txtAlbum.Text;
            novamusica.Duracao = TimeSpan.Parse(txtDuracao.Text);
            novaplay.Inserir(novamusica);
            ListaMusicas.ItemsSource = novaplay.Listar();
        }

        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            ListaMusicas.ItemsSource = novaplay.Listar();
        }

        private void TempoTotal_Click(object sender, RoutedEventArgs e)
        {
            txtDuracTotal.Text = novaplay.TempoTotal().ToString();
        }
    }
}
