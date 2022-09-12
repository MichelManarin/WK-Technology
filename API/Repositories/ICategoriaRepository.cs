using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Repositories
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> GetAll();
        Task<Categoria> Add(Categoria categoria);
        Task<Categoria> GetById(int id);
        Task Update(Categoria categoria);
        Task DeleteById(int id);
    }
}