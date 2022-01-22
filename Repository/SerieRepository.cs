using CrudSeriesEFilmes.Interfaces;
using CrudSeriesEFilmes.Models;
using System.Collections.Generic;
using System.Linq;

namespace CrudSeriesEFilmes.Repository
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> series = new List<Serie>();

        public void Atualizar(int id, Serie entidade)
        {
            series[id] = entidade;
        }

        public void Excluir(int id)
        {
            //series.RemoveAt(id);
            series[id].Excluir();

        }

        public void Inserir(Serie entidade)
        {
            series.Add(entidade);
        }

        public List<Serie> Listar()
        {
            return series;
        }

        public int ProximoId()
        {
            return series.Count;
        }

        public Serie RetornarPorId(int id)
        {
            return (Serie) series.Where(s => s.Id == id);

        }
    }
}
