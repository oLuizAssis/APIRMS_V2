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
        private readonly RMSContext _context;
        public UsuarioController() =>
            _context = new RMSContext();

        [HttpGet]
        [Route("ObterUsuario")]
        public IActionResult GetLogar(string email)
        {
            

            var usuario = _context.Usuario.Where(x => x.Email == email).FirstOrDefault();
            if (usuario != null)
                return Ok(usuario);
            else
                return NotFound();
           
        }

        [HttpGet]
        [Route("DeletarUsuario")]
        public IActionResult DeletarUsuario(string email)
        {

            var usuario = _context.Usuario.Where(x => x.Email == email).FirstOrDefault();

            if(usuario != null)
                _context.Usuario.Remove(usuario);

            _context.SaveChanges();

            return Ok(usuario);

        }
    }
}
