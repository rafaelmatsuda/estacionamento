using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstacionamento.Data
{
    public class VeiculoService
    {
        private readonly EstacionamentoDbContext _db;

        public VeiculoService(EstacionamentoDbContext db)
        {
            _db = db;
        }

        // Busca Veiculos
        public List<Veiculo> GetVeiculo()
        {
            var VeiculoList = _db.Veiculos.ToList();
            return VeiculoList;
        }

        // Insere Veiculo

        public string Create(Veiculo Veiculo)
        {
            _db.Veiculos.Add(Veiculo);
            _db.SaveChanges();
            return "Veiculo salvo com sucesso!";
        }

        //Busca Veiculo por id
        public Veiculo GetVeiculoById(int id)
        {
            Veiculo Veiculo = _db.Veiculos.FirstOrDefault(m => m.Id == id);
            return Veiculo;
        }

        // Atualiza Veiculo
        public string UpdateVeiculo(Veiculo Veiculo)
        {
            _db.Veiculos.Update(Veiculo);
            _db.SaveChanges();
            return "Veiculo atualizado com sucesso !";
        }

        // Apaga Veiculo
        public string DeleteVeiculo(Veiculo Veiculo)
        {
            _db.Remove(Veiculo);
            _db.SaveChanges();
            return String.Format("Veiculo {0} excluído com sucesso", Veiculo.Id);
        }
    }
}
