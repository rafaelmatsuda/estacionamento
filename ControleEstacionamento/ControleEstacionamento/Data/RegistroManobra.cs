using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstacionamento.Data
{
    public class RegistroManobra
    {
        public int Id { get; set; }
        public Veiculo Veiculo { get; set; }
        public Manobrista Manobrista { get; set; }
        public DateTime DataManobra { get; set; }
    }
}
