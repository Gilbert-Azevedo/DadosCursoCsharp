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
        public MainWindow()
        {
            InitializeComponent();
        }
        Paciente x = new Paciente("", "", "", DateTime.Parse("01/01/1900"));
        private void Idade_Click(object sender, RoutedEventArgs e)
        {
            x.Nome = txtNome.Text;
            x.Cpf = txtCpf.Text;
            x.Telefone = txtTelefone.Text;
            x.Nascimento = DateTime.Parse(txtNascimento.Text);
            txtdados.Text = x.Idade;
        }

        private void Dados_Click(object sender, RoutedEventArgs e)
        {
            
            txtdados.Text = x.ToString();
        }
    }
}
