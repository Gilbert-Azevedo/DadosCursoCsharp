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
        public MainWindow()
        {
            InitializeComponent();
        }

        private Agenda agenda = new Agenda();

        private void Inserir_Click(object sender, RoutedEventArgs e)
        {
            Compromisso c = new Compromisso();
            c.Assunto = txtAssunto.Text;
            c.Local = txtLocal.Text;
            c.Data = dtData.SelectedDate.Value;
            agenda.Inserir(c);

        }

        private void Excluir_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Listar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Pesquisar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
