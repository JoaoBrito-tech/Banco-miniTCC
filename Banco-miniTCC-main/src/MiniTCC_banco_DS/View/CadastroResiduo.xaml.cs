using System.Windows;
using MiniTCC_banco_DS.Dados;
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
            if (!int.TryParse(TxtId.Text, out int id))
            {
                MessageBox.Show("Informe um ID válido (número inteiro).", "Dados inválidos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                MessageBox.Show("Informe o nome do resíduo.", "Dados inválidos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (CmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Selecione o tipo do resíduo.", "Dados inválidos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!int.TryParse(TxtConf.Text, out int confianca))
            {
                MessageBox.Show("Informe um código de identificação válido (número inteiro).", "Dados inválidos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var residuo = new Residuo
            {
                Id = id,
                Nome = TxtNome.Text.Trim(),
                Tipo = CmbTipo.Text,
                ConfiancaIdentificacao = confianca,
            };

            Repositorio.SalvarResiduo(residuo);

            MessageBox.Show(
                $"Resíduo cadastrado com sucesso!\nID: {residuo.Id}\nNome: {residuo.Nome}\nTipo: {residuo.Tipo}\nCódigo: {residuo.ConfiancaIdentificacao}\nHorário: {residuo.DataHora}",
                "Cadastro concluído", MessageBoxButton.OK, MessageBoxImage.Information);

            LimparCampos();
        }

        private void BtnVoltar_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void BtnApagar_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(TxtId.Text, out int id))
            {
                MessageBox.Show("Informe o ID do resíduo que deseja apagar.", "ID inválido", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Repositorio.RemoverResiduo(id))
            {
                MessageBox.Show("Resíduo removido com sucesso.", "Removido", MessageBoxButton.OK, MessageBoxImage.Information);
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Nenhum resíduo encontrado com esse ID.", "Não encontrado", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void LimparCampos()
        {
            TxtId.Text = string.Empty;
            TxtNome.Text = string.Empty;
            TxtConf.Text = string.Empty;
            CmbTipo.SelectedIndex = -1;
        }
    }
}
