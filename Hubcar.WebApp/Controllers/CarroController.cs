﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hubcar.WebApp.Controllers
{
    [Route("api/[controller]/{action=Index}")]
    [ApiController]
    public class CarroController : ControllerBase
    {
    }
}