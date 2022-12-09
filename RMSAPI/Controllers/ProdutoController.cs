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
                    Descricao = "AMPLIFICADOR_EDITION_BLUE_60R_HUGHES_&_KETTNER_60W",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 2000,
                    IdCategoria = 1,
                    Status = 1,
                    Foto = _utilFoto.getFoto("prod_id1_01.jpg")
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "EPIPHONE_WILDKAT_2006_SUNRISE_ORANGE",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 3500,
                    IdCategoria = 2,
                    Status = 1,
                    Foto = _utilFoto.getFoto("prod_id2_01.jpg")
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "CONTRABAIXO_FENDER_SIG_SERIES_DUFF_MCKAGAN_DELUXE_PRECISION_BASS",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 12996,
                    IdCategoria = 2,
                    Status = 1,
                    Foto = _utilFoto.getFoto("prod_id3_01.jpg")
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "VIOLAO_GIBSON_SJ200_STANDARD",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 25500,
                    IdCategoria = 2,
                    Status = 1,
                    Foto = _utilFoto.getFoto("prod_id4_01.jpg")
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "VIOLINO_ANTONI_MARSALE_OFICINA_2022_GUARNERI",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 5500,
                    IdCategoria = 2,
                    Status = 1,
                    Foto = _utilFoto.getFoto("prod_id5_01.jpg")
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "KIT_CONTRABAIXO_FENDER",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 8000,
                    IdCategoria = 2,
                    Status = 1,
                    Foto = _utilFoto.getFoto("prod_id6_01.jpg")
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "BATERIA_PREMIER_SIGNIA_MAPLE_CHERRY_WOOD",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 20000,
                    IdCategoria = 3,
                    Status = 1,
                    Foto = _utilFoto.getFoto("prod_id7_01.jpg")
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "BATERIA_ACUSTICA_D_ONE_ROCKET_DR18",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 3600,
                    IdCategoria = 2,
                    Status = 1,
                    Foto = _utilFoto.getFoto("prod_id8_01.jpg")
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "ENCORDOAMENTO_DADDARIO_GUITARRA_010_EXL110",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 67,
                    IdCategoria = 4,
                    Status = 1,
                    Foto = _utilFoto.getFoto("prod_id9_01.jpg")
                });
                db.SaveChanges();
                db.Produto.Add(new Produto()
                {
                    DataEntrada = DateTime.Now.AddDays(-1 * (rnd.Next(1, 30))),
                    DataSaida = DateTime.Now.AddDays(rnd.Next(1, 30)),
                    Descricao = "CAPOTRASTE_JOYO",
                    Estoque = rnd.Next(1, 99),
                    ValorProduto = 40,
                    IdCategoria = 4,
                    Status = 1,
                    Foto = _utilFoto.getFoto("prod_id10_01.jpg")
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
