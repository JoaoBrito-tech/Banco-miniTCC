using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTCC_banco_DS.Models
{
    public class Residuo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public DateTime DataHora { get; set; } = DateTime.Now;
        public int ConfiancaIdentificacao { get; set; }
    }
}
