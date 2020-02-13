using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstacionamento.Data
{
    public class Manobrista
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public DateTime DtNascimento { get; set; }
    }
}
