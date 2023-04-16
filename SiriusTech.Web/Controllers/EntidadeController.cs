using Microsoft.AspNetCore.Mvc;
using SiriusTech.Data.Models;
using SiriusTech.Data.Services;

namespace SiriusTech.Web.Controllers
{
    public class EntidadeController : Controller
    {
        private EntidadeServices _entidadeServices = new EntidadeServices();

        public IActionResult Index()
        {
            List<Entidade> listEntidade = _entidadeServices.repositoryEntidade.SelecionarTodos();
            return View(listEntidade);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Entidade model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _entidadeServices.repositoryEntidade.Incluir(model);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Entidade Entidade = _entidadeServices.repositoryEntidade.SelecionarPk(id);
            return View(Entidade);
        }

        public IActionResult Edit(int id) 
        {
            Entidade Entidade = _entidadeServices.repositoryEntidade.SelecionarPk(id);
            return View(Entidade);
        }

        [HttpPost]
        public IActionResult Edit(Entidade model)
        {
            Entidade Entidade = _entidadeServices.repositoryEntidade.Alterar(model);

            int id = Entidade.IdEntidade;

            return RedirectToAction("Details", new { id });
        }

        public IActionResult Delete(int id)
        {
            _entidadeServices.repositoryEntidade.Excluir(id);
            return RedirectToAction("index");
        }


    }
}
