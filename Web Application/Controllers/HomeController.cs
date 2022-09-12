
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Web_Application.Models;
using Web_Application.Services;

namespace Web_Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpProdutoService _produtoService;

        public HomeController(IHttpProdutoService produtoService, ILogger<HomeController> logger)
        {
            _produtoService = produtoService;
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var produtos = await _produtoService.GetAllProdutos();
            return View(produtos);
        }

        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _produtoService.DeleteProduto(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categorias = await _produtoService.GetAllCategorias();
         
            SelectList selectList = new SelectList(categorias, "Id", "Nome");
         
            ViewBag.ListaCategorias = selectList;

            ProdutoViewModel produto = new ProdutoViewModel();

            return View(produto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProdutoViewModel model)
        {
            if (!ModelState.IsValid){

                var categorias = await _produtoService.GetAllCategorias();
         
                SelectList selectList = new SelectList(categorias, "Id", "Nome");
         
                ViewBag.ListaCategorias = selectList;

                return View(model);
            }

            await _produtoService.CreateProduto(model);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            var produto = await _produtoService.GetProdutoById(id);
            
            var categorias = await _produtoService.GetAllCategorias();
         
            SelectList selectList = new SelectList(categorias, "Id", "Nome");
         
            ViewBag.ListaCategorias = selectList;

            return View(produto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProdutoViewModel model)
        {
            if (!ModelState.IsValid){

                var categorias = await _produtoService.GetAllCategorias();
         
                SelectList selectList = new SelectList(categorias, "Id", "Nome");
         
                ViewBag.ListaCategorias = selectList;

                return View(model);
            }

            await _produtoService.UpdateProduto(model);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
