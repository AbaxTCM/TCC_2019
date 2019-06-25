using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace etec.bg.abax.maitre.MVC.Controllers
{
    public class ReservaRestController : Controller
    {
        // GET: ReservaRest
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            Models.Reserva.ReservaData.ReservaRestData data = new Models.Reserva.ReservaData.ReservaRestData();
            return View(data.GetLista());
        }

        // GET: ReservaRest/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReservaRest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservaRest/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ReservaRest/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReservaRest/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: ReservaRest/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservaRest/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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