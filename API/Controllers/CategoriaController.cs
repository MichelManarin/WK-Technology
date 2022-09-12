using System;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using Microsoft.Extensions.Logging;
using API.Repositories;

namespace API.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private DataContext _dataContext;
        private readonly ILogger _logger;
        private ICategoriaRepository _categoriaRepository;

        public CategoriaController(DataContext context, ICategoriaRepository categoriaRepository, ILogger<CategoriaController> logger){
            _dataContext = context;
            _categoriaRepository = categoriaRepository;
            _logger = logger;
        }


        [HttpGet("{id}")]
        public ActionResult getbyid(int id)
        {
            try{
                var categoria = _categoriaRepository.GetById(id);
                
                return Ok(categoria);

            } catch(Exception ex){

                _logger.LogError("Error get by id:", ex?.Message);

                return BadRequest();
            }
        }

        [HttpGet("list")]
        public async Task<ActionResult> list()
        {
            try{
                var categorias = await _categoriaRepository.GetAll();

                return Ok(categorias);

            } catch(Exception ex){

                _logger.LogError("Error at list:", ex?.Message);

                return BadRequest();
            }
        }

        [HttpPost("create")]
        public async Task<ActionResult> create([FromBody] Categoria categoria)
        {
            try{
                await _categoriaRepository.Add(categoria);

            } catch(Exception ex){
               _logger.LogError("Error at create:", ex?.Message);

               return BadRequest();
            }
            
            return Created("", categoria);
        }

        [HttpPut("update")]
        public async Task<ActionResult> update([FromBody] Categoria categoria)
        {
            try{
                await _categoriaRepository.Update(categoria);

            } catch(Exception ex){
               _logger.LogError("Error at update:", ex?.Message);

               return BadRequest();
            }
            
            return Ok(categoria);
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> delete(int id)
        {
            try{
                await _categoriaRepository.DeleteById(id);

            } catch(Exception ex){
               _logger.LogError("Error at delete:", ex?.Message);

               return BadRequest();
            }
            
            return Ok();
        }

    }
}