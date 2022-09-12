using System.ComponentModel.DataAnnotations;

namespace Web_Application.Models
{
    public class CategoriaViewModel
    {
        public int Id { get; set;}

        [Required(ErrorMessage = "Informe o nome da categoria")]
        [MaxLength(100, ErrorMessage="Este campo deve conter entre 3 e 100 caracteres")]
        [MinLength(3, ErrorMessage="Este campo deve conter entre 3 e 100 caracteres")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}