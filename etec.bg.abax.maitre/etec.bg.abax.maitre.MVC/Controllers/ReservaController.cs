using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace etec.bg.abax.maitre.MVC.Controllers
{
    public class ReservaController : Controller
    {
        // GET: Reserva
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reserva/Details/5
        public ActionResult Detalhar()
        {
            Models.Reserva.ReservaData.ReservaData data = new Models.Reserva.ReservaData.ReservaData();
            return View(data.GetReserva());
        }

        public ActionResult Listar()
        {
            Models.Reserva.ReservaData.ReservaData data = new Models.Reserva.ReservaData.ReservaData();
            return View(data.GetLista());
        }

        // GET: Reserva/Create
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: Reserva/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Models.Reserva.Reserva collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }

        // GET: Reserva/Edit/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: Reserva/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, Models.Reserva.Reserva collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }

        // GET: Reserva/Delete/5
        public ActionResult Deletar(int id)
        {
            return View();
        }

        // POST: Reserva/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(int id, Models.Reserva.Reserva collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }
    }
}