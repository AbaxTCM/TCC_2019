using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace etec.bg.abax.maitre.MVC.Controllers
{
    public class BebidaController : Controller
    {
        // GET: Bebida
        public ActionResult Index()
        {
            return View();
        }

        // GET: Bebida/Details/5
        public ActionResult Detalhar(int id)
        {
            return View();
        }

        public ActionResult Listar()
        {
            return View();
        }

        // GET: Bebida/Create
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: Bebida/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Models.Cardapio.Bebida collection)
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

        // GET: Bebida/Edit/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: Bebida/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, Models.Cardapio.Bebida collection)
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

        // GET: Bebida/Delete/5
        public ActionResult Deletar(int id)
        {
            return View();
        }

        // POST: Bebida/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(int id, Models.Cardapio.Bebida collection)
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