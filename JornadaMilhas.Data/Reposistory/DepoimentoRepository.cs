using ChallengeJornadaMilhas.Business;
using JornadaMilhas.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JornadaMilhas.Data.Reposistory
{
    public class DepoimentoRepository : Repository<Depoimento>
    {
        public DepoimentoRepository(JornadaMilhasDbContext context) : base(context) { }

        public async Task<Depoimento> ObterProdutoFornecedor(Guid id)
        {
            return await Db.Depoimentos.AsNoTracking().Include(f => f.Fornecedor)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Depoimento>> ObterProdutosFornecedores()
        {
            return await Db.Depoimentos.AsNoTracking().Include(f => f.Fornecedor)
                .OrderBy(p => p.Nome).ToListAsync();
        }

        public async Task<IEnumerable<Depoimento>> ObterProdutosPorFornecedor(Guid fornecedorId)
        {
            return await Buscar(p => p.FornecedorId == fornecedorId);
        }
    }
}
