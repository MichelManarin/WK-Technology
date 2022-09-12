using System.Text.Json.Serialization;

namespace API.Requests
{
    public class CreateProductRequest
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }
        
        public int CategoriaId { get; set; }

        public double Preco { get; set; }
    }
}