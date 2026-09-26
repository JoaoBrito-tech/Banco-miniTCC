using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTCC_banco_DS.Models
{
    public class ExemploLixeira
    {
        public Lixeira Vidro { get; set; } = new Lixeira
        {
            Id = 1,
            Nome = "Lixeira para Vidro",
            Localizacao = "Centro de reciclagem, Rua A, 123",
            Status = "Ativa"
        };
        public Lixeira Papel { get; set; } = new Lixeira
        {
            Id = 2,
            Nome = "Lixeira para Papel",
            Localizacao = "Centro de reciclagem, Rua A, 123",
            Status = "Ativa"
        };

        public Lixeira Metal { get; set; } = new Lixeira
        {
            Id = 1,
            Nome = "Lixeira para Metal",
            Localizacao = "Centro de reciclagem, Rua A, 123",
            Status = "Ativa"
        };

        public Lixeira Organico { get; set; } = new Lixeira
        {
            Id = 1,
            Nome = "Lixeira orgânica",
            Localizacao = "Centro de reciclagem, Rua A, 123",
            Status = "Ativa"
        };

        public Lixeira Plastico { get; set; } = new Lixeira
        {
            Id = 1,
            Nome = "Lixeira para Plástico",
            Localizacao = "Centro de reciclagem, Rua A, 123",
            Status = "Ativa"
        };
    }
}
