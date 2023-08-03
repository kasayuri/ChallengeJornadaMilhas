using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JornadaMilhas.Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable
    {
        Task Adicionar(TEntity entity);
        Task<TEntity> ObterPorId(Guid id);
        Task<List<TEntity>> ObterTodos();
        Task Atualizar(TEntity entity);
        Task Remover(Guid id);
        Task<int> SaveChanges();
    }
}
