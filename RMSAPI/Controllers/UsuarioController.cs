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
        [Route("GetLogar")]
        public IActionResult GetLogar(string email, string senha)
        {
            RMSContext db = new RMSContext();
           
            if (db.Usuario.Where(x => x.Email == email && x.Senha == senha).FirstOrDefault() != null)
            {
                return Ok(true);
            }
            else
            {
                return NotFound();
            }

           
        }


    }
}
