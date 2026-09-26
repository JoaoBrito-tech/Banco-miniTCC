using System;
using System.Windows;
using MiniTCC_banco_DS.Dados;
using MiniTCC_banco_DS.Models;

namespace MiniTCC_banco_DS.View
{
    /// <summary>
    /// Lógica interna para CadastroRegistro.xaml
    /// </summary>
    public partial class CadastroRegistro : Window
    {
        public CadastroRegistro()
        {
            InitializeComponent();
            TxtDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void BtnEnviar_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(TxtId.Text, out int id))
            {
                MessageBox.Show("Informe um ID válido (número inteiro).", "Dados inválidos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtResultado.Text))
            {
                MessageBox.Show("Informe o resultado do registro.", "Dados inválidos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var registro = new Registro
            {
                Id = id,
                DataHora = DateTime.Now,
                Resultado = TxtResultado.Text.Trim(),
            };

            Repositorio.SalvarRegistro(registro);

            MessageBox.Show(
                $"Registro cadastrado com sucesso!\nID: {registro.Id}\nData/Hora: {registro.DataHora}\nResultado: {registro.Resultado}",
                "Cadastro concluído", MessageBoxButton.OK, MessageBoxImage.Information);

            LimparCampos();
        }

        private void BtnApagar_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(TxtId.Text, out int id))
            {
                MessageBox.Show("Informe o ID do registro que deseja apagar.", "ID inválido", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Repositorio.RemoverRegistro(id))
            {
                MessageBox.Show("Registro removido com sucesso.", "Removido", MessageBoxButton.OK, MessageBoxImage.Information);
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado com esse ID.", "Não encontrado", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void LimparCampos()
        {
            TxtId.Text = string.Empty;
            TxtResultado.Text = string.Empty;
            TxtDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

    }
}
