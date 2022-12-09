using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RMSAPI.Models
{
    public class Produto
    {
        [Key]
        [JsonPropertyName("ID")]
        public int Id { get; set; }
        [JsonPropertyName("DESCRICAO")]
        public string? Descricao { get; set; }
        [JsonPropertyName("DATAENTRADA")]
        public DateTime DataEntrada { get; set; }
        [JsonPropertyName("DATASAIDA")]
        public DateTime DataSaida { get; set; }
        [JsonPropertyName("ESTOQUE")]
        public int Estoque { get; set; }
        [JsonPropertyName("VALORPRODUTO")]
        public decimal ValorProduto { get; set; }
        [JsonPropertyName("STATUS")]
        public int Status { get; set; }
        [JsonPropertyName("IDCATEGORIA")]
        public int IdCategoria { get; set; }
        [JsonPropertyName("FOTO")]
        public string? Foto { get; set; }

    }
}
