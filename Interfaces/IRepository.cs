using System;
using System.Collections.Generic;
using System.Text;

namespace CrudSeriesEFilmes.Interfaces
{
   public interface IRepository<T>
    {
        List<T> Listar();
        T RetornarPorId(int id);
        void Inserir(T entidade);
        void Excluir(int id);
        void Atualizar(int id, T entidade);
        int ProximoId();
    }
}
