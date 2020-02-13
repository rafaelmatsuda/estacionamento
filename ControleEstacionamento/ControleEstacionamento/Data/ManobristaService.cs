using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstacionamento.Data
{
    public class ManobristaService
    {
        private readonly EstacionamentoDbContext _db;

        public ManobristaService(EstacionamentoDbContext db)
        {
            _db = db;
        }

        // Busca Manobristas
        public List<Manobrista> GetManobrista()
        {
            var manobristaList = _db.Manobristas.ToList();
            return manobristaList;
        }

        // Insere Manobrista

        public string Create(Manobrista manobrista)
        {
            _db.Manobristas.Add(manobrista);
            _db.SaveChanges();
            return "Manobrista salvo com sucesso!";
        }

        //Busca manobrista por id
        public Manobrista GetManobristaById(int id)
        {
            Manobrista manobrista = _db.Manobristas.FirstOrDefault(m => m.Id == id);
            return manobrista;
        }

        // Atualiza Manobrista
        public string UpdateManobrista(Manobrista manobrista)
        {
            _db.Manobristas.Update(manobrista);
            _db.SaveChanges();
            return "Manobrista atualizado com sucesso !";
        }

        // Apaga Manobrista
        public string DeleteManobrista(Manobrista manobrista)
        {
            _db.Remove(manobrista);
            _db.SaveChanges();
            return String.Format("Manobrista {0} excluído com sucesso", manobrista.Id);
        }
    }
}
