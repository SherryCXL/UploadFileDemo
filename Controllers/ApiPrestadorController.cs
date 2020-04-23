using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo2.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo2.Controllers
{
    [ApiVersion("1")]
    [Route("v{v:apiVersion}/[controller]")]
    [ApiController]
    public class ApiPrestadorController : ControllerBase
    {
        [HttpPost("Upload2")]
        public async Task<IActionResult> Upload2(FotoViewModel model)
        {
            try
            {
                if (model == null) return BadRequest("Arquivo não fornecido");

                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}