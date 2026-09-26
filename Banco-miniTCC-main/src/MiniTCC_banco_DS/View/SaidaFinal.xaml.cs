using System.Windows;
using MiniTCC_banco_DS.Dados;

namespace MiniTCC_banco_DS.View
{
    /// <summary>
    /// Tela de Saída Final: reúne e exibe, de forma organizada, tudo o que foi
    /// cadastrado nas telas de Lixeira, Resíduo e Registro.
    /// </summary>
    public partial class SaidaFinal : Window
    {
        public SaidaFinal()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            GridLixeiras.ItemsSource = Repositorio.Lixeiras;
            GridResiduos.ItemsSource = Repositorio.Residuos;
            GridRegistros.ItemsSource = Repositorio.Registros;

            TxtTotalLixeiras.Text = $"Total: {Repositorio.Lixeiras.Count}";
            TxtTotalResiduos.Text = $"Total: {Repositorio.Residuos.Count}";
            TxtTotalRegistros.Text = $"Total: {Repositorio.Registros.Count}";
        }

        private void BtnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            CarregarDados();
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
