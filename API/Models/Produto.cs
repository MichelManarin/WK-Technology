using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Produto
    {
        
        [Key]
        public int Id { get; set;}

        [Required(ErrorMessage = "Nome é obrigatório")]
        [MaxLength(100, ErrorMessage="Este campo deve conter entre 3 e 100 caracteres")]
        [MinLength(3, ErrorMessage="Este campo deve conter entre 3 e 100 caracteres")]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(300)]
        [MaxLength(300, ErrorMessage="Este campo deve conter entre 3 e 300 caracteres")]
        [MinLength(3, ErrorMessage="Este campo deve conter entre 3 e 300 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Categoria é obrigatório")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [Required]
        [Range(1, double.PositiveInfinity)]
        public double Preco { get; set; }
        public bool Ativo { get; set; }



    }
}