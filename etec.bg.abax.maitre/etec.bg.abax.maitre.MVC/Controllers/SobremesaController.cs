using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace etec.bg.abax.maitre.MVC.Controllers
{
    public class SobremesaController : Controller
    {
        Models.Cardapio.CardapioData.SobremesaData data = new Models.Cardapio.CardapioData.SobremesaData();
        // GET: Sobremesa
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            return View(data.GetLista());
        }

        // GET: Sobremesa/Details/5
        public ActionResult Detalhar(int id)
        {
            return View(data.GetSobremesa(id));
        }

        // GET: Sobremesa/Create
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: Sobremesa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Models.Cardapio.Sobremesa collection)
        {
            try
            {
                data.PostSobremesa(collection);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Sobremesa/Edit/5
        public ActionResult Editar(int id)
        {
            return View(data.GetSobremesa(id));
        }

        // POST: Sobremesa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, Models.Cardapio.Sobremesa collection)
        {
            try
            {
                data.EditSobremesa(collection, id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Sobremesa/Delete/5
        public ActionResult Deletar(int id)
        {
            return View(data.GetSobremesa(id));
        }

        // POST: Sobremesa/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(int id, Models.Cardapio.Sobremesa collection)
        {
            try
            {
                data.DeleteSobremesa(collection, id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}