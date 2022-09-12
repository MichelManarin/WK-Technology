
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web_Application.Models;
using Web_Application.Services;

namespace Web_Application.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ILogger<CategoriaController> _logger;
        private readonly IHttpProdutoService _produtoService;

        public CategoriaController(IHttpProdutoService produtoService, ILogger<CategoriaController> logger)
        {
            _produtoService = produtoService;
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var categorias = await _produtoService.GetAllCategorias();
            return View(categorias);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
         public async Task<IActionResult> Create(CategoriaViewModel model)
        {
            if (!ModelState.IsValid){
                return View(model);
            }

            await _produtoService.CreateCategoria(model);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _produtoService.DeleteCategoria(id);
            return RedirectToAction("Index");
        }
        
    }
}
