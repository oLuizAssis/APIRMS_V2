using Microsoft.AspNetCore.Mvc;
using RMSAPI.Models;
using RMSAPI.Util;
using static System.Net.Mime.MediaTypeNames;

namespace RMSAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
       
        [HttpGet]
        [Route("ObterUsuario")]
        public IActionResult GetLogar(string email)
        {
            RMSContext db = new RMSContext();

            var usuario = db.Usuario.Where(x => x.Email == email).FirstOrDefault();
            if (usuario != null)
                return Ok(usuario);
            else
                return NotFound();
           
        }
    }
}
