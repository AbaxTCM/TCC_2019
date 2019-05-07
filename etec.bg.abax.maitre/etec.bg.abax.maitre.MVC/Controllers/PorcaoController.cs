using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace etec.bg.abax.maitre.MVC.Controllers
{
    public class PorcaoController : Controller
    {
        // GET: Porcao
        public ActionResult Index()
        {
            return View();
        }

        // GET: Porcao/Details/5
        public ActionResult Detalhar(int id)
        {
            return View();
        }

        // GET: Porcao/Create
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: Porcao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Models.Cardapio.Porcao collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Porcao/Edit/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: Porcao/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, Models.Cardapio.Porcao collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Porcao/Delete/5
        public ActionResult Deletar(int id)
        {
            return View();
        }

        // POST: Porcao/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(int id, Models.Cardapio.Porcao collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}