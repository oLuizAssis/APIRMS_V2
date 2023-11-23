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


        [HttpPost]
        [Route("CadastrarUsuario")]
        public IActionResult CadastrarUsuario([FromBody] Usuario novoUsuario)
        {
            try
            {
                //verificação se o e-mail já existe na base
                var usuarioExistente = _context.Usuario.FirstOrDefault(x => x.Email == novoUsuario.Email);

                if (usuarioExistente != null)

                {
                    return BadRequest("Erro! E-mail já utilizado por outro usuário.");
                }

                // adicionando novo usuario
                _context.Usuario.Add(novoUsuario);
                _context.SaveChanges();

                return Ok("Usuário cadastrado com sucesso.");

            }

            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno do Servidor: what?!");
            }
              
            }




           //var usuario = _context.Usuario.Where(x => x.Email == email).FirstOrDefault();

           // if(usuario == null)
           // {
           //     return BadRequest("Dados inválidos");
           // }

           //     _context.Usuario.Add(usuario);

           // _context.SaveChanges();

           // return Ok(usuario);

        }



    
}
