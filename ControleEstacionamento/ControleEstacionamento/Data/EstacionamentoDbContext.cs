using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstacionamento.Data
{
    public class EstacionamentoDbContext : DbContext
    {
        public EstacionamentoDbContext(DbContextOptions<EstacionamentoDbContext> options)
            :base(options)
        {

        }
        
        public DbSet<Manobrista> Manobristas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<RegistroManobra> RegistroManobras { get; set; }
    }
}
