using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RMSAPI.Models
{
    public class Categoria
    {
        [Key]
        [JsonPropertyName("ID")]
        public int Id { get; set; }
        [JsonPropertyName("DESCRICAO")]
        public string? Descricao { get; set; }
        [JsonPropertyName("IDCATEGORIAPAI")]
        public int IdCategoriaPai { get; set; }
        [JsonPropertyName("STATUS")]
        public int Status { get; set; }
    }
}
