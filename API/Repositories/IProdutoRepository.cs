using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;

namespace API.Repositories
{
    public interface IProdutoRepository
    {
         Task<IEnumerable<Produto>> GetAll();
         Task<Produto> Add(Produto produto);
         Produto GetById(int id);
         Task Update(Produto produto);
         Task DeleteById(int id);
    }
}