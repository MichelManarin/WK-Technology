using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private DataContext _dataContext;

        public CategoriaRepository([FromServices] DataContext dataContext){
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<Categoria>> GetAll(){

            var categorias = await _dataContext.categoria
                                .AsNoTracking()
                                .ToListAsync();
            
            return categorias;
        } 

        public async Task<Categoria> Add(Categoria categoria){

            var response = _dataContext.categoria.Add(categoria);

            await _dataContext.SaveChangesAsync();

            return response?.Entity;
        }

        public async Task<Categoria> GetById(int id)
        {
            var categoria = await _dataContext.categoria
                                .AsNoTracking()
                                .Where(x => x.Id == id)
                                .FirstOrDefaultAsync();

            return categoria;
        }

        public async Task Update(Categoria categoria)
        {
            _dataContext.categoria.Update(categoria);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteById(int id)
        {
            var categoria = _dataContext.categoria.Find(id);  

            if (categoria != null){
                _dataContext.categoria.Remove(categoria);
            
                await _dataContext.SaveChangesAsync();
            }

            
        }
    }
}