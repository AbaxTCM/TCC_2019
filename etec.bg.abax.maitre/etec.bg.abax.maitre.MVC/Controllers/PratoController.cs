using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace etec.bg.abax.maitre.MVC.Controllers
{
    public class PratoController : Controller
    {
        // GET: Prato
        public ActionResult Index()
        {
            return View();
        }

        // GET: Prato/Details/5
        public ActionResult Detalhar(int id)
        {
            return View();
        }

        // GET: Prato/Create
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: Prato/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Models.Cardapio.Prato collection)
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

        // GET: Prato/Edit/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: Prato/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, Models.Cardapio.Prato collection)
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

        // GET: Prato/Delete/5
        public ActionResult Deletar(int id)
        {
            return View();
        }

        // POST: Prato/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(int id, Models.Cardapio.Prato collection)
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