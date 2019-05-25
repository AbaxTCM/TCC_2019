using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace etec.bg.abax.maitre.MVC.Controllers
{
    public class ClienteController : Controller
    {
        Models.Pessoa.PessoaData.ClienteData data = new Models.Pessoa.PessoaData.ClienteData();
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cliente/Details/5
        public ActionResult Detalhar(int id)
        {
            return View(data.GetCliente(id));
        }

        public ActionResult Listar()
        {
            return View(data.GetLista());
        }

        // GET: Cliente/Create
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Models.Pessoa.Cliente collection)
        {
            try
            {
                data.PostCliente(collection);

                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Editar(int id)
        {
            return View(data.GetCliente(id));
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, Models.Pessoa.Cliente collection)
        {
            try
            {
                data.EditCliente(collection, id);

                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Deletar(int id)
        {
            return View(data.GetCliente(id));
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(int id, Models.Pessoa.Cliente collection)
        {
            try
            {
                data.DeleteCliente(collection, id);

                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }
    }
}