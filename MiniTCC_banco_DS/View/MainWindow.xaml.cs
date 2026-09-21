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

namespace MiniTCC_banco_DS.View
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

        private void BtnIniciar_Click(object sender, RoutedEventArgs e)
        {
            if (Opcoes.Visibility == Visibility.Collapsed)
            {
                Opcoes.Visibility = Visibility.Visible;
                BtnIniciar.Content = "Fechar";
            }
            else
            {
                Opcoes.Visibility = Visibility.Collapsed;
                BtnIniciar.Content = "Iniciar";
            }
        }

        private void BtnCadastroLixeira_Click(object sender, RoutedEventArgs e)
        {
            CadastroLixeira cadastroLixeira = new CadastroLixeira(); //mudar de pagina
            cadastroLixeira.Show();
            this.Close();
        }

        private void BtnCadastroResiduos_Click(object sender, RoutedEventArgs e)
        {
            CadastroResiduo cadastroResiduos = new CadastroResiduo();
            cadastroResiduos.Show();
            this.Close();
        }

        private void BtnCadastroRegistros_Click(object sender, RoutedEventArgs e)
        {
            CadastroRegistro cadastroRegistros = new CadastroRegistro();
            cadastroRegistros.Show();
            this.Close();
        }
    }

}
