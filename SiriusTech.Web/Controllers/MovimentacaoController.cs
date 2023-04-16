using Microsoft.AspNetCore.Mvc;
using SiriusTech.Data.Models;
using SiriusTech.Data.Services;
using SiriusTech.Web.Models;

namespace SiriusTech.Web.Controllers
{
    public class MovimentacaoController : Controller
    {
        private MovimentacaoServices _service = new MovimentacaoServices();

        public IActionResult Index()
        {
            List<ViewMovimentacao> litsViewMovimentacao = _service.repositoryViewMovimentacao.SelecionarTodos();
            return View();
        }

        public IActionResult Create()
        {
            MovimentacaoViewModel movimentacaoViewModel = new MovimentacaoViewModel();

            List<Entidade> listEntidade = _service.repositoryEntidade.SelecionarTodos();
            List<TipoMovimentacao> listTipoMovimentacao = _service.repositoryTipoMovimentacao.SelecionarTodos();


            movimentacaoViewModel.listEntidade = listEntidade;
            movimentacaoViewModel.listTipoMovimentacao = listTipoMovimentacao;

            movimentacaoViewModel.movimentacao = new Movimentacao();

            movimentacaoViewModel.movimentacao.DataRegistro = DateTime.Now;
            //movimentacaoViewModel.movimentacao.LceDataEntrega = DateTime.Now.AddDays(7);

            return View(movimentacaoViewModel);
        }

        [HttpPost]
        public ActionResult Create(Movimentacao movimentacao) 
        {           
            if (!ModelState.IsValid)
            {
                return View();
            }

            _service.repositoryMovimentacao.Incluir(movimentacao);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            MovimentacaoViewModel _MovimentacaoViewModel = new MovimentacaoViewModel();

            _MovimentacaoViewModel.listEntidade = _service.repositoryEntidade.SelecionarTodos();
            _MovimentacaoViewModel.listTipoMovimentacao = _service.repositoryTipoMovimentacao.SelecionarTodos();

            Movimentacao movimentacao = _service.repositoryMovimentacao.SelecionarPk(id);
            _MovimentacaoViewModel.movimentacao = movimentacao;


            return View(_MovimentacaoViewModel);
        }

        [HttpPost]
        public IActionResult Edit(MovimentacaoViewModel MovimentacaoViewModel)
        {
            if (!ModelState.IsValid)
            {
                MovimentacaoViewModel.listEntidade = _service.repositoryEntidade.SelecionarTodos();
                MovimentacaoViewModel.listTipoMovimentacao = _service.repositoryTipoMovimentacao.SelecionarTodos();
                return View(MovimentacaoViewModel);
            }


            _service.repositoryMovimentacao.Alterar(MovimentacaoViewModel.movimentacao);

            return RedirectToAction("Index");
        }
    }
}
