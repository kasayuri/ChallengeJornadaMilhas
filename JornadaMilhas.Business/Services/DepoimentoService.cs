using JornadaMilhas.Business.Interfaces;
using JornadaMilhas.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JornadaMilhas.Business.Services
{
    public class DepoimentoService : IDepoimentoService
    {

        private readonly IDepoimentoRepository _depoimentoRepository;

        public DepoimentoService(IDepoimentoRepository depoimentoRepository)
        {
            _depoimentoRepository = depoimentoRepository;
        }

        public async Task Adicionar(Depoimento depoimento)
        {
            if (!ExecutarValidacao(new DepoimentoValidation(), Depoimento)) return;

            //var user = _user.GetUserId();

            await _depoimentoRepository.Adicionar(depoimento);
        }

        public async Task Atualizar(Depoimento depoimento)
        {
            if (!ExecutarValidacao(new DepoimentoValidation(), Depoimento)) return;

            await _depoimentoRepository.Atualizar(depoimento);
        }

        public async Task Remover(Guid id)
        {
            await _depoimentoRepository.Remover(id);
        }

        public void Dispose()
        {
            _depoimentoRepository?.Dispose();
        }
    }
}
