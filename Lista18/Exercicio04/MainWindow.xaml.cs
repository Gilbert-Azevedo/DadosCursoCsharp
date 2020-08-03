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

namespace Exercicio04
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private Agenda agenda;
        public MainWindow()
        {
            InitializeComponent();
              agenda = new Agenda();
        }

      
        private void Inserir_Click(object sender, RoutedEventArgs e)
        {
            Compromisso c = new Compromisso();
            c.Assunto = txtAssunto.Text;
            c.Local = txtLocal.Text;
            c.Data = dtData.SelectedDate.Value;
            agenda.Inserir(c);
            List.ItemsSource = agenda.Listar();
        }

        private void Excluir_Click(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem == null)
                MessageBox.Show("Nenhum Item Selecionado!");
            else
            {
                Compromisso c = (Compromisso)List.SelectedItem;
                agenda.Excluir(c);
                List.ItemsSource = agenda.Listar();
            }
        }

        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            List.ItemsSource = agenda.Listar();
        }

        private void Pesquisar_Click(object sender, RoutedEventArgs e)
        {
            int m = int.Parse(txtMes.Text);
            int a = int.Parse(txtAno.Text);
            List.ItemsSource = agenda.Pesquisar(m, a);

        }
    }
}
