using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static etec.bg.abax.maitre.MVC.Program;

namespace etec.bg.abax.maitre.MVC.Controllers
{
    public class RestauranteController : Controller
    {
        private readonly IHostingEnvironment he;
        public RestauranteController(IHostingEnvironment e)
        {
            he = e;
        }
        Models.Estabelecimento.RestauranteData.RestauranteData data = new Models.Estabelecimento.RestauranteData.RestauranteData();
        // GET: Restaurante
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            Models.Estabelecimento.RestauranteData.RestauranteData data = new Models.Estabelecimento.RestauranteData.RestauranteData();
            return View(data.GetLista());
        }

        // GET: Restaurante/Details/5
        public ActionResult Detalhar(int id)
        {
            id = int.Parse(Session.Instance.RestID.ToString());
            return View(data.GetRestaurante(id));
        }

        // GET: Restaurante/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurante/Create
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

        // GET: Restaurante/Edit/5
        public ActionResult Editar(int id)
        {
            return View(data.GetRestaurante(id));
        }

        // POST: Restaurante/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, Models.Estabelecimento.Restaurante collection, IFormFile pic)
        {
            try
            {
                if (pic != null)
                {
                    collection.imagem = pic.FileName;
                    var fileName = Path.Combine(he.WebRootPath + "\\uploadImages", Path.GetFileName(pic.FileName));
                    using(FileStream fs = new FileStream(fileName, FileMode.Create))
                    {
                        pic.CopyTo(fs);
                    }
                }
                data.EditRestaurante(collection, id);

                return RedirectToAction("Menu","Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: Restaurante/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Restaurante/Delete/5
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