using System.Windows;
using MiniTCC_banco_DS.Dados;
using MiniTCC_banco_DS.Models;

namespace MiniTCC_banco_DS.View
{
    /// <summary>
    /// Lógica interna para CadastroLixeira.xaml
    /// </summary>
    public partial class CadastroLixeira : Window
    {
        public CadastroLixeira()
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

            if (string.IsNullOrWhiteSpace(TxtNome.Text) || string.IsNullOrWhiteSpace(TxtLocalizacao.Text))
            {
                MessageBox.Show("Preencha o nome e a localização da lixeira.", "Dados inválidos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var lixeira = new Lixeira
            {
                Id = id,
                Nome = TxtNome.Text.Trim(),
                Localizacao = TxtLocalizacao.Text.Trim(),
                Status = "Ativa",
            };

            Repositorio.SalvarLixeira(lixeira);

            MessageBox.Show(
                $"Lixeira cadastrada com sucesso!\nID: {lixeira.Id}\nNome: {lixeira.Nome}\nLocalização: {lixeira.Localizacao}",
                "Cadastro concluído", MessageBoxButton.OK, MessageBoxImage.Information);

            LimparCampos();
        }

        private void BtnApagar_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(TxtId.Text, out int id))
            {
                MessageBox.Show("Informe o ID da lixeira que deseja apagar.", "ID inválido", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Repositorio.RemoverLixeira(id))
            {
                MessageBox.Show("Lixeira removida com sucesso.", "Removido", MessageBoxButton.OK, MessageBoxImage.Information);
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Nenhuma lixeira encontrada com esse ID.", "Não encontrado", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void LimparCampos()
        {
            TxtId.Text = string.Empty;
            TxtNome.Text = string.Empty;
            TxtLocalizacao.Text = string.Empty;
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

    }
}
