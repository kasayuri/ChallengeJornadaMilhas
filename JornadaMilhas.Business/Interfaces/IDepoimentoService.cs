using JornadaMilhas.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JornadaMilhas.Business.Interfaces
{
    public interface IDepoimentoService : IDisposable
    {
        Task Adicionar(Depoimento depoimento);
        Task Atualizar(Depoimento depoimento);
        Task Remover(Guid id);
    }
}
