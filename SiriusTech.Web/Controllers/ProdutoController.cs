using Microsoft.AspNetCore.Mvc;
using SiriusTech.Data.Models;
using SiriusTech.Data.Services;

namespace SiriusTech.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoServices _produtoServices = new ProdutoServices();

        public IActionResult Index()
        {
            List<Produto> listProduto = _produtoServices.repositoryProduto.SelecionarTodos();
            return View(listProduto);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _produtoServices.repositoryProduto.Incluir(model);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Produto Produto = _produtoServices.repositoryProduto.SelecionarPk(id);
            return View(Produto);
        }

        public IActionResult Edit(int id)
        {
            Produto Produto = _produtoServices.repositoryProduto.SelecionarPk(id);
            return View(Produto);
        }

        [HttpPost]
        public IActionResult Edit(Produto model)
        {
            Produto Produto = _produtoServices.repositoryProduto.Alterar(model);

            int id = Produto.IdProduto;

            return RedirectToAction("Details", new { id });
        }

        public IActionResult Delete(int id)
        {
            _produtoServices.repositoryProduto.Excluir(id);
            return RedirectToAction("index");
        }
    }
}

