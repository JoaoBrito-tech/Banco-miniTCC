using System.Collections.ObjectModel;
using System.Linq;
using MiniTCC_banco_DS.Models;

namespace MiniTCC_banco_DS.Dados
{
    /// <summary>
    /// Repositório central em memória do sistema.
    /// Funciona como o "banco de dados" da aplicação: tudo o que é cadastrado
    /// nas telas de Lixeira, Resíduo e Registro fica guardado aqui, e é a partir
    /// daqui que a tela de Saída Final lê e exibe as informações de forma organizada.
    /// </summary>
    public static class Repositorio
    {
        public static ObservableCollection<Lixeira> Lixeiras { get; } = new ObservableCollection<Lixeira>();
        public static ObservableCollection<Residuo> Residuos { get; } = new ObservableCollection<Residuo>();
        public static ObservableCollection<Registro> Registros { get; } = new ObservableCollection<Registro>();

        // ---------- LIXEIRAS ----------
        public static void SalvarLixeira(Lixeira lixeira)
        {
            var existente = Lixeiras.FirstOrDefault(l => l.Id == lixeira.Id);
            if (existente != null)
            {
                existente.Nome = lixeira.Nome;
                existente.Localizacao = lixeira.Localizacao;
                existente.Status = lixeira.Status;
            }
            else
            {
                Lixeiras.Add(lixeira);
            }
        }

        public static bool RemoverLixeira(int id)
        {
            var existente = Lixeiras.FirstOrDefault(l => l.Id == id);
            if (existente == null) return false;
            Lixeiras.Remove(existente);
            return true;
        }

        // ---------- RESÍDUOS ----------
        public static void SalvarResiduo(Residuo residuo)
        {
            var existente = Residuos.FirstOrDefault(r => r.Id == residuo.Id);
            if (existente != null)
            {
                existente.Nome = residuo.Nome;
                existente.Tipo = residuo.Tipo;
                existente.ConfiancaIdentificacao = residuo.ConfiancaIdentificacao;
                existente.DataHora = residuo.DataHora;
            }
            else
            {
                Residuos.Add(residuo);
            }
        }

        public static bool RemoverResiduo(int id)
        {
            var existente = Residuos.FirstOrDefault(r => r.Id == id);
            if (existente == null) return false;
            Residuos.Remove(existente);
            return true;
        }

        // ---------- REGISTROS ----------
        public static void SalvarRegistro(Registro registro)
        {
            var existente = Registros.FirstOrDefault(r => r.Id == registro.Id);
            if (existente != null)
            {
                existente.DataHora = registro.DataHora;
                existente.Resultado = registro.Resultado;
            }
            else
            {
                Registros.Add(registro);
            }
        }

        public static bool RemoverRegistro(int id)
        {
            var existente = Registros.FirstOrDefault(r => r.Id == id);
            if (existente == null) return false;
            Registros.Remove(existente);
            return true;
        }
    }
}
