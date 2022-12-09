using System.ComponentModel.DataAnnotations;

namespace RMSAPI.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }
        public string? CEP { get; set; }
        public string? Perfil { get; set; }
        public string? N_Imovel { get; set; }
        public string? Endereco { get; set; }
        public int Status { get; set; }

    }
}
