using System.ComponentModel.DataAnnotations;

namespace Web_Application.Models
{
    public class ProdutoViewModel
    {
        public int Id { get; set;}

        [Required(ErrorMessage = "Informe o nome do produto")]
        [MaxLength(100, ErrorMessage="Este campo deve conter entre 3 e 100 caracteres")]
        [MinLength(3, ErrorMessage="Este campo deve conter entre 3 e 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a descrição do produto")]
        [MaxLength(100, ErrorMessage="Este campo deve conter entre 3 e 100 caracteres")]
        [MinLength(3, ErrorMessage="Este campo deve conter entre 3 e 100 caracteres")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Descrição")]
        public CategoriaViewModel Categoria { get; set; }

        [Required(ErrorMessage = "Informe a categoria do produto")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Informe o preço do produto")]
        [Range(1, double.PositiveInfinity)]
        [Display(Name = "Preço")]
        public double Preco { get; set; }
        public bool Ativo { get; set; }
    }
}