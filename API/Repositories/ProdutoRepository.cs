using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private DataContext _dataContext;

        public ProdutoRepository(DataContext context){
            _dataContext = context;
        }
        public async Task<IEnumerable<Produto>> GetAll(){

            var produtos = await _dataContext.produto
                .Include(x => x.Categoria)
                .ToListAsync();

            return produtos;
        } 

        public Produto GetById(int id){

            var produto = _dataContext.produto.Find(id);

            return produto;
        }

        public async Task<Produto> Add(Produto produto){

            var response = _dataContext.produto.Add(produto);

            await _dataContext.SaveChangesAsync();

            return response?.Entity;
        }

        public async Task Update(Produto produto){
            
            _dataContext.produto.Update(produto);

            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteById(int id){
            
            var produto = _dataContext.produto.Find(id);  

            if (produto != null){
                _dataContext.produto.Remove(produto);

                await _dataContext.SaveChangesAsync();
            }
        }

    }
}