using ChallengeJornadaMilhas.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeJornadaMilhas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepoimentosController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<DepoimentosController> _logger;

        public DepoimentosController(ILogger<DepoimentosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Depoimento> Buscar(int id)
        {
            
        }

        [HttpPost]
        public IEnumerable<Depoimento> Criar()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Depoimento
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPut]
        public IEnumerable<Depoimento> Atualizar()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Depoimento
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpDelete]
        public IEnumerable<Depoimento> Deletar()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Depoimento
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
