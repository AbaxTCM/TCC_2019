using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace etec.bg.abax.maitre.MVC.Controllers
{
    public class SobremesaController : Controller
    {
        private readonly IHostingEnvironment he;
        public SobremesaController(IHostingEnvironment e)
        {
            he = e;
        }
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
        public ActionResult Cadastrar(Models.Cardapio.Sobremesa collection, IFormFile pic)
        {
            try
            {
                if (pic != null)
                {
                    collection.imagem = pic.FileName;
                    var fileName = Path.Combine(he.WebRootPath + "\\uploadImages", Path.GetFileName(pic.FileName));
                    pic.CopyTo(new FileStream(fileName, FileMode.Create));
                }
                data.PostSobremesa(collection);

                return RedirectToAction(nameof(Listar));
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
        public ActionResult Editar(int id, Models.Cardapio.Sobremesa collection, IFormFile pic)
        {
            try
            {
                if (pic != null)
                {
                    collection.imagem = pic.FileName;
                    var fileName = Path.Combine(he.WebRootPath + "\\uploadImages", Path.GetFileName(pic.FileName));
                    pic.CopyTo(new FileStream(fileName, FileMode.Create));
                }
                data.EditSobremesa(collection, id);

                return RedirectToAction(nameof(Listar));
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

                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }
    }
}