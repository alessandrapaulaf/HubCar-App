using System;
using Hubcar.Domain.BusinessException;
using Hubcar.Domain.Models;
using System.Threading.Tasks;
using Hubcar.Domain.HubcarDbContext;
using Hubcar.Portal.Web.Models;
using Hubcar.Domain.AppServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Hubcar.WebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/{action=Index}")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly HubcarDBContext _context;
        private readonly UsuarioServices _usuarioServices;
        public UsuarioController
            (HubcarDBContext context,
            UsuarioServices usuarioServices)
        {
            _context = context;
            _usuarioServices = usuarioServices;
        }

        // POST: api/Usuario/Create
        [HttpPost]
        public IActionResult Create([FromBody] UsuarioEditModel model)
        {
            if (string.IsNullOrEmpty(model.Senha) || string.IsNullOrEmpty(model.Cpf) || string.IsNullOrEmpty(model.Cidade)
                || string.IsNullOrEmpty(model.Uf) || string.IsNullOrEmpty(model.Email) || string.IsNullOrEmpty(model.Nome))
            {
                throw new BusinessException("Campos Obrigatórios não inseridos.");
            }

            if (model.Cpf.Length != 11)
                throw new BusinessException("CPF inválido.");

            if (_context.Usuario.Where(u => u.Email == model.Email).Any())
                throw new BusinessException("Já existe uma conta com esse email.");

            if(_context.Usuario.Where(u => u.Cpf.Equals(model.Cpf)).Any())
                throw new BusinessException("Já existe uma conta com esse CPF.");

            var id = new Random();

            try
            {
                _context.Add(new Usuario()
                {
                    Id = id.Next(4000),
                    Nome = model.Nome,
                    Email = model.Email,
                    Senha = model.Senha,
                    Cpf = model.Cpf,
                    Cidade = model.Cidade,
                    Uf = model.Uf
                });

                _context.SaveChanges();
            }
            catch (Exception error)
            {
                new BusinessException(error.Message);
            }

            return Ok();
        }

        public Usuario ObterUsuarioAtual()
        {
            return _usuarioServices.ObterUsuarioLogado();
        }
    }
}
