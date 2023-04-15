using Microsoft.AspNetCore.Mvc;
using SiriusTech.Data.Models;
using SiriusTech.Data.Services;

namespace SiriusTech.Web.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteServices _clienteServices = new ClienteServices();

        public IActionResult Index()
        {
            List<Cliente> listCliente = _clienteServices.repositoryCliente.SelecionarTodos();
            return View(listCliente);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _clienteServices.repositoryCliente.Incluir(model);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Cliente cliente = _clienteServices.repositoryCliente.SelecionarPk(id);
            return View(cliente);
        }

        public IActionResult Edit(int id) 
        {
            Cliente cliente = _clienteServices.repositoryCliente.SelecionarPk(id);
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Edit(Cliente model)
        {
            Cliente cliente = _clienteServices.repositoryCliente.Alterar(model);

            int id = cliente.Id;

            return RedirectToAction("Details", new { id });
        }

        public IActionResult Delete(int id)
        {
            _clienteServices.repositoryCliente.Excluir(id);
            return RedirectToAction("index");
        }


    }
}
