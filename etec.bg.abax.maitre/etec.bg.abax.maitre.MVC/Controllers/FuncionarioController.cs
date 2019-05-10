using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace etec.bg.abax.maitre.MVC.Controllers
{
    public class FuncionarioController : Controller
    {
        Models.Pessoa.PessoaData.FuncionarioData data = new Models.Pessoa.PessoaData.FuncionarioData();
        // GET: Funcionario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            return View(data.GetLista());
        }

        // GET: Funcionario/Details/5
        public ActionResult Detalhar(int id)
        {
            return View(data.GetFuncionario(id));
        }

        // GET: Funcionario/Create
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: Funcionario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Models.Pessoa.Funcionario collection)
        {
            try
            {
                data.PostFuncionario(collection);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/Edit/5
        public ActionResult Editar(int id)
        {
            return View(data.GetFuncionario(id));
        }

        // POST: Funcionario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, Models.Pessoa.Funcionario collection)
        {
            try
            {
                data.EditFuncionario(collection, id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/Delete/5
        public ActionResult Deletar(int id)
        {
            return View(data.GetFuncionario(id));
        }

        // POST: Funcionario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(int id, Models.Pessoa.Funcionario collection)
        {
            try
            {
                data.DeleteFuncionario(collection, id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}