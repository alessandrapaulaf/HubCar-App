using Hubcar.Domain.BusinessException;
using Hubcar.Domain.HubcarDbContext;
using Hubcar.Portal.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Hubcar.Domain.Models;
using System;

namespace Hubcar.Portal.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        public ActionResult Create(UsuarioEditModel model)
        {
            var context = new HubcarDBContext();

            if (string.IsNullOrEmpty(model.Senha) || string.IsNullOrEmpty(model.Cpf) || string.IsNullOrEmpty(model.Cidade)
                || string.IsNullOrEmpty(model.Uf) || string.IsNullOrEmpty(model.Email) || string.IsNullOrEmpty(model.Nome))
            {
                throw new BusinessException("Campos Obrigatórios não inseridos.");
            }

            if (model.Cpf.Length != 11)
                throw new BusinessException("CPF inválido.");

            var id = new Random();

            try
            {
                context.Add(new Usuario()
                {
                    Id = id.Next(4000),
                    Nome = model.Nome,
                    Email = model.Email,
                    Senha = model.Senha,
                    Cpf = model.Cpf,
                    Cidade = model.Cidade,
                    Uf = model.Uf
                });

                context.SaveChanges();
            }
            catch (Exception error)
            {
                new BusinessException(error.ToString());
            }

            return Ok();
        }
    }
}
