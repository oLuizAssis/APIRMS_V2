using System.ComponentModel.DataAnnotations;

namespace RMSAPI.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public int IdCategoriaPai { get; set; }
        public int Status { get; set; }
    }
}
