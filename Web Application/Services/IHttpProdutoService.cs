using System.Collections.Generic;
using System.Threading.Tasks;
using Web_Application.Models;

namespace Web_Application.Services
{
    public interface IHttpProdutoService
    {
        Task<ProdutoViewModel> GetProdutoById(int id);
        Task<List<CategoriaViewModel>> GetAllCategorias();
        Task<List<ProdutoViewModel>> GetAllProdutos();
        Task<List<ProdutoViewModel>> DeleteProduto(int produtoId);
        Task DeleteCategoria(int produtoId);
        Task<CategoriaViewModel> CreateCategoria(CategoriaViewModel categoria);
        Task<ProdutoViewModel> CreateProduto(ProdutoViewModel produto);
        Task<ProdutoViewModel> UpdateProduto(ProdutoViewModel produto);
         
    }
}