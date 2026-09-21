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
using System.Windows.Shapes;

namespace MiniTCC_banco_DS.View
{
    /// <summary>
    /// Lógica interna para CadastroResiduo.xaml
    /// </summary>
    public partial class CadastroResiduo : Window
    {
        public CadastroResiduo()
        {
            InitializeComponent();
        }
   

        private void BtnVoltar_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
