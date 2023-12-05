using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RMSAPI.Models
{
    public class Usuario
    {
        [Key]
        [JsonPropertyName("ID")]
        public int Id { get; set; }
        [JsonPropertyName("NOME")]
        public string Nome { get; set; }
        [JsonPropertyName("SENHA")]
        public string? Senha { get; set; }
        [JsonPropertyName("CPF")]
        public string CPF { get; set; }
        [JsonPropertyName("EMAIL")]
        public string? Email { get; set; }
        [JsonPropertyName("CEP")]
        public string? CEP { get; set; }
        [JsonPropertyName("PERFIL")]
        public string? Perfil { get; set; }
        [JsonPropertyName("N_IMOVEL")]
        public string? N_Imovel { get; set; }
        [JsonPropertyName("ENDERECO")]
        public string? Endereco { get; set; }
        [JsonPropertyName("STATUS")]
        public int Status { get; set; }

    }
}
