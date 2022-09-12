using System;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using Microsoft.Extensions.Logging;
using API.Repositories;
using API.Requests;

namespace API.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ILogger _logger;
        private IProdutoRepository _productRepository;
        private ICategoriaRepository _categoriaRepository;

        public ProdutoController(IProdutoRepository productRepository, ICategoriaRepository categoriaRepository, ILogger<ProdutoController> logger){
            _productRepository = productRepository;
            _categoriaRepository = categoriaRepository;
            _logger = logger;
        }

        
        [HttpGet("{id}")]
        public ActionResult getbyid(int id)
        {
            try{
                var produto = _productRepository.GetById(id);
                
                return Ok(produto);

            } catch(Exception ex){

                _logger.LogError("Error at getbyid:", ex?.Message);

                return BadRequest();
            }
        }

        [HttpGet("list")]
        public async Task<ActionResult> list()
        {
            try{

                var produtos = await _productRepository.GetAll();

                return Ok(produtos);

            } catch(Exception ex){

                _logger.LogError("Error at list:", ex?.Message);

                return BadRequest();
            }
        }

        [HttpPost("create")]
        public async Task<ActionResult> create([FromBody] Produto produto)
        {
            try{
                produto.Ativo = true;
                await _productRepository.Add(produto);

            } catch(Exception ex){
               _logger.LogError("Error at create:", ex?.Message);

               return BadRequest();
            }

            return Created("", produto);
        }

        [HttpPut("update")]
        public async Task<ActionResult> update([FromBody] Produto produto)
        {
            try{
                await _productRepository.Update(produto);

            } catch(Exception ex){
               _logger.LogError("Error at update:", ex?.Message);

               return BadRequest();
            }
            
            return Ok(produto);
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> delete(int id)
        {
            try{
                await _productRepository.DeleteById(id);

            } catch(Exception ex){
               _logger.LogError("Error at delete:", ex?.Message);

               return BadRequest();
            }
            
            return Ok();
        }
    }
}