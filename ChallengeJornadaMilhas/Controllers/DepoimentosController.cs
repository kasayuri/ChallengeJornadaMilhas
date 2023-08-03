using AutoMapper;
using JornadaMilhas.Business.Interfaces;
using JornadaMilhas.Business.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChallengeJornadaMilhas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepoimentosController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDepoimentoRepository _depoimentoRepository;
        private readonly IDepoimentoService _depoimentoService;
        private readonly ILogger<DepoimentosController> _logger;

        public DepoimentosController(IMapper mapper, IDepoimentoRepository depoimentoRepository, IDepoimentoService depoimentoService, ILogger<DepoimentosController> logger)
        {
            _mapper = mapper;
            _depoimentoRepository = depoimentoRepository;
            _depoimentoService = depoimentoService;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Depoimento> Buscar(int id)
        {
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new Depoimento
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
            return new List<Depoimento>();
        }

        [HttpPost]
        public async Task<Depoimento> Criar(Depoimento depoimento)
        {
            //await _depoimentoService.Adicionar(_mapper.Map<Depoimento>(depoimentoViewModel));
            await _depoimentoService.Adicionar(depoimento);

            return new Depoimento();

//            return new Depoimento();
        }

        [HttpPut]
        public Depoimento Atualizar()
        {
            return new Depoimento();
        }

        [HttpDelete]
        public bool Deletar()
        {
            return true;
        }
    }
}
