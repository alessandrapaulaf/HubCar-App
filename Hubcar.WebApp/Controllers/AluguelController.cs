using Hubcar.Domain.HubcarDbContext;
using Hubcar.Portal.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Hubcar.WebApp.Controllers
{
    [Route("api/[controller]/{action=Index}")]
    [ApiController]
    public class AluguelController : ControllerBase
    {
        public readonly HubcarDBContext _context;

        public AluguelController
            (HubcarDBContext context)
        {
            _context = context;
        }

        //public IActionResult Create(AluguelEditModel model)
        //{
            
        //}
    }
}
