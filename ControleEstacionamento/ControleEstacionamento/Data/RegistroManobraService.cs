using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ControleEstacionamento.Data
{
    public class RegistroManobraService
    {
        private readonly EstacionamentoDbContext _db;

        public RegistroManobraService(EstacionamentoDbContext db)
        {
            _db = db;
        }

        // Busca Manobristas
        public List<RegistroManobra> GetRegistroManobras()
        {
            var registroList = _db.RegistroManobras.Include(veiculo => veiculo.Veiculo).Include(manobrista => manobrista.Manobrista).ToList();
            return registroList;
        }

        public string Create(RegistroManobra manobra)
        {
            _db.RegistroManobras.Add(manobra);
            _db.SaveChanges();
            return "Manobra salva com sucesso!";
        }

        //Busca manobrista por id
        public RegistroManobra GetRegistroManobraById(int id)
        {
                RegistroManobra manobra = _db.RegistroManobras.Include(veiculo => veiculo.Veiculo).Include(manobrista => manobrista.Manobrista).Where(m => m.Id == id).FirstOrDefault();
                return manobra;
            
        }

        // Atualiza Manobrista
        public string UpdateRegistroManobra(RegistroManobra manobra)
        {
            _db.RegistroManobras.Update(manobra);
            _db.SaveChanges();
            return "Manobra atualizada com sucesso !";
        }

        // Apaga Manobrista
        public string DeleteRegistroManobra(RegistroManobra manobra)
        {
            _db.Remove(manobra);
            _db.SaveChanges();
            return String.Format("Manobra {0} excluído com sucesso", manobra.Id);
        }
    }
}
