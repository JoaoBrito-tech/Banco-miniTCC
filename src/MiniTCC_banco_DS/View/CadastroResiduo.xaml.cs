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
using MiniTCC_banco_DS.Models;

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

        private void BtnEnviar_Click(object sender, RoutedEventArgs e)
        {
            var residuo = new Residuo
            {
                Id = int.Parse(TxtId.Text),
                Nome = TxtNome.Text,
                Tipo = CmbTipo.Text,
                ConfiancaIdentificacao = int.Parse(TxtConf.Text),
            };
      
            MessageBox.Show($"Registro concluído!\nID: {residuo.Id}\nNome: {residuo.Nome}\nTipo: {residuo.Tipo}\nCódigo: {residuo.ConfiancaIdentificacao}\nHorário: {residuo.DataHora}\n\nClique em OK para ver qual a lixeira apropriada.", "Registro concluído", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnVoltar_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void BtnApagar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
