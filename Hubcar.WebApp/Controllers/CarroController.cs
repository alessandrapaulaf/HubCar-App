using Hubcar.Domain.Models;
using Hubcar.Domain.AppServices;
using Hubcar.Domain.BusinessException;
using Hubcar.Domain.HubcarDbContext;
using Hubcar.Portal.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.JSInterop;

namespace Hubcar.WebApp.Controllers
{
    [Route("api/[controller]/{action=Index}")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        public readonly UsuarioServices _usuarioServices;
        public readonly HubcarDBContext _context;

        public CarroController
            (UsuarioServices usuarioServices,
            HubcarDBContext context)
        {
            _usuarioServices = usuarioServices;
            _context = context;
        }


        // POST: api/Carro/Create
        [HttpPost]
        public IActionResult Create(CarroEditModel model)
        {
            var usuarioLogado = _usuarioServices.ObterUsuarioLogado();
            var id = new Random();

            if (string.IsNullOrEmpty(model.Modelo) || model.Ano == null || string.IsNullOrEmpty(model.Placa)
                || model.ValorDiaria == null)
            {
                throw new BusinessException("Campos Obrigatórios não inseridos.");
            }

            if (model.Placa.Length != 7)
                throw new BusinessException("Placa inválida.");

            if (model.ValorDiaria < 1)
                throw new BusinessException("O valor da diária não pode ser menor 1");

            try
            {
                _context.Add(new Carro()
                {
                    Id = id.Next(4000),
                    Modelo = model.Modelo,
                    Ano = model.Ano.ToString(),
                    Placa = model.Placa,
                    ValorDiaria = model.ValorDiaria,
                    Proprietario = usuarioLogado
                });
            } catch(Exception error)
            {
                throw new BusinessException(error.Message);
            }

            return Ok();
        }
    }
}
