using Microsoft.AspNetCore.Mvc;
using RMSAPI.Models;
using RMSAPI.Util;
using static System.Net.Mime.MediaTypeNames;

namespace RMSAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        public Foto _utilFoto { get; set; }
        public ProdutoController()
        {
            _utilFoto = new Foto();
        }

        [HttpGet]
        public IActionResult Get()
        {
            RMSContext db = new RMSContext();
            return Ok(db.Produto
            .ToArray());
        }

        [HttpGet]
        [Route("PopularBase")]
        public IActionResult GetPopularBase()
        {
            try
            {
                RMSContext db = new RMSContext();
                Random rnd = new Random();

                db.Produto.RemoveRange(db.Produto.ToList());
                db.SaveChanges();
                db.Categoria.RemoveRange(db.Categoria.ToList());
                db.SaveChanges();
                db.Usuario.RemoveRange(db.Usuario.ToList());
                db.SaveChanges();

                db.Categoria.Add(new Categoria { Id = 1, Descricao = "Eletronicos" });
                db.Categoria.Add(new Categoria { Id = 2, Descricao = "Cordas" });
                db.Categoria.Add(new Categoria { Id = 3, Descricao = "Percussao" });
                db.Categoria.Add(new Categoria { Id = 4, Descricao = "Acessorios" });
                db.SaveChanges();

                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "AMPLIFICADOR EDITION BLUE 60R HUGHES & KETTNER 60W",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 2000,
                    IdCategoria = 1,
                    Status = 1,
                    Foto = "https://www.musikland-online.de/pix/onlineshop/Hughes--Kettner-Editon-Blue-60-DFX-.jpg"
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "EPIPHONE WILDKAT 2006 SUNRISE ORANGE",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 3500,
                    IdCategoria = 2,
                    Status = 1,
                    Foto = "https://rvb-img.reverb.com/image/upload/s--xKZ5fPcT--/f_auto,t_supersize/v1552655568/bzstnspbcqyodlkzhisx.jpg"
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "CONTRABAIXO SQUIER AFFINITY PRECISION PJ CHARCOAL FROST METALLIC",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 12996,
                    IdCategoria = 2,
                    Status = 1,
                    Foto = "https://sirclocdn.com/nafiriguitar/products/_211109103414_AST%2052SH%20VWH%20-%20Copy%20-%20Copy_full.JPG"
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "VIOLAO GIBSON NOEL GALLAGHER J-150",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 25500,
                    IdCategoria = 2,
                    Status = 1,
                    Foto = "https://1.bp.blogspot.com/-Ju86PmkUMlk/YNI57BC4P4I/AAAAAAAAY2Y/jUzUIE_N0e4xWqtiK4XST4jQvc39BfpJwCLcBGAsYHQ/w640-h426/unnamed%2B%25281%2529.jpg"
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "VIOLINO ANTONI MARSALE OFICINA 2022 GUARNERI",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 5500,
                    IdCategoria = 2,
                    Status = 1,
                    Foto = "https://http2.mlstatic.com/D_NQ_NP_2X_888926-MLB52732862865_122022-F.webp" 
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "KIT CONTRABAIXO FENDER",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 8000,
                    IdCategoria = 2,
                    Status = 1,
                    Foto = "https://http2.mlstatic.com/D_NQ_NP_2X_889723-MLB46925600774_072021-F.webp"
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "BATERIA PREMIER SIGNIA MAPLE CHERRY WOOD",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 20000,
                    IdCategoria = 3,
                    Status = 1,
                    Foto = "https://cdnbatera.bateraclube.com.br/files/122/MED_Bateria-Premier-Signia-Maple-Cherry-Wood-22--8--10--12--14--16--(Seminovo)-Decada-90.JPG"
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "BATERIA ACUSTICA D ONE ROCKET DR18",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 3600,
                    IdCategoria = 2,
                    Status = 1,
                    Foto = "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcQyFXuh72oy0sAfFyLxBYyPgHpO3ty2WmweVJnSlJZ0PoOBlNOvS5PiOvADYYqhIRHk9UMgZcIvvkI4e1iUDRFWZ9dSi8oRCOup0uIjuBPzmxl-jXf6L37y"
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "ENCORDOAMENTO DADDARIO GUITARRA 010 EXL110",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 67,
                    IdCategoria = 4,
                    Status = 1,
                    Foto = "https://http2.mlstatic.com/D_NQ_NP_2X_749797-MLB40512519815_012020-F.webp"
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "CAPOTRASTE JOYO",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 40,
                    IdCategoria = 4,
                    Status = 1,
                    Foto = "https://sc04.alicdn.com/kf/HTB1Je1RXyYrK1Rjy0Fdq6ACvVXau.jpg"
                });
                db.SaveChanges();


                db.Usuario.Add(new Usuario()
                {
                    Nome = "Luiz Assis",
                    Senha = "12345678",
                    CPF = "99999999999",
                    Email = "oluiz.assis@gmail.com",
                    CEP = "79011420",
                    Perfil = "Comprador",
                    N_Imovel = "409",
                    Endereco = "Al Teste",
                    Status = 1
                });
                db.SaveChanges();
                db.Usuario.Add(new Usuario()
                {
                    Nome = "Ruberval Taylor",
                    Senha = "87654321",
                    CPF = "88888888888",
                    Email = "ruber.taylor@gmail.com",
                    CEP = "79022457",
                    Perfil = "Vendedor",
                    N_Imovel = "30",
                    Endereco = "Al Central",
                    Status = 1
                });
                db.SaveChanges();


                return Ok(true);
            }
            catch (Exception ex){ 
                return BadRequest(ex); 
            }
        }


    }
}
