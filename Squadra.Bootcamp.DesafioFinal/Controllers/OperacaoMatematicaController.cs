using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Squadra.Bootcamp.DesafioFinal.Models;
using Squadra.Bootcamp.DesafioFinal.Repositories;
using Squadra.Bootcamp.DesafioFinal.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra.Bootcamp.DesafioFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperacoesMatematicas : ControllerBase
    {

        private readonly ILogger<OperacoesMatematicas> _logger;
        private readonly FuncaoMatematica _funcaoMatematica;
        public OperacoesMatematicas(ILogger<OperacoesMatematicas> logger)
        {
            _logger = logger;
            _funcaoMatematica = new FuncaoMatematica();
        }

        [HttpPost]
        [Route("ObterToken")]

        public async Task<ActionResult<dynamic>> Authenticate([FromBody] User model)
        {
            var user = UserRepository.Get(model.Username, model.Password);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);
            user.Password = "";
            
            return new
            {
                user,
                token
            };
        }


        [HttpGet]
        [Route("/somar")]
        public double ObterSoma([Required]double valor_1, double valor_2)
        {
            return _funcaoMatematica.Somar(valor_1, valor_2);
        }

        [HttpGet]
        [Route("/subitrair")]
        public double ObterSubitracao([Required] double valor_1, double valor_2)
        {
            return _funcaoMatematica.Subitrair(valor_1, valor_2);
        }

        [HttpGet]
        [Route("/multiplicar")]
        [Authorize]
        public double ObterMultiplicacao([Required] double valor_1, double valor_2)
        {
            return Math.Round(_funcaoMatematica.Multiplicar(valor_1, valor_2),2);
        }

        [HttpGet]
        [Route("/dividir")]
        [Authorize(Roles = "MATEMATICO")]
        public double ObterDivisao([Required] double valor_1, double valor_2)
        {
            return Math.Round( _funcaoMatematica.Dividir(valor_1, valor_2),2);
        }

    }
}
