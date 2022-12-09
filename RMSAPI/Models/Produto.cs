using System.ComponentModel.DataAnnotations;

namespace RMSAPI.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public int Estoque { get; set; }
        public decimal ValorProduto { get; set; }
        public int Status { get; set; }
        public int IdCategoria { get; set; }
        public string? Foto { get; set; }

    }
}
