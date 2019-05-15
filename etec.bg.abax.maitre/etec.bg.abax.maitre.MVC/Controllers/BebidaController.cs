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
        Models.Cardapio.CardapioData.BebidaData data = new Models.Cardapio.CardapioData.BebidaData();
        // GET: Bebida
        public ActionResult Index()
        {
            return View();
        }

        // GET: Bebida/Details/5
        public ActionResult Detalhar(int id)
        {
            return View(data.GetBebida(id));
        }

        public ActionResult Listar()
        {
            return View(data.GetLista());
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
                data.PostBebida(collection);

                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }

        // GET: Bebida/Edit/5
        public ActionResult Editar(int id)
        {
            return View(data.GetBebida(id));
        }

        // POST: Bebida/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, Models.Cardapio.Bebida collection)
        {
            try
            {
                data.EditBebida(collection, id);

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
            return View(data.GetBebida(id));
        }

        // POST: Bebida/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(int id, Models.Cardapio.Bebida collection)
        {
            try
            {
                data.DeleteBebida(collection, id);

                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }
    }
}