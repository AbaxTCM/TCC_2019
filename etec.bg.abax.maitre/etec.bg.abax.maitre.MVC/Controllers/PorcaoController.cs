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
    public class PorcaoController : Controller
    {
        private readonly IHostingEnvironment he;
        public PorcaoController(IHostingEnvironment e)
        {
            he = e;
        }
        Models.Cardapio.CardapioData.PorcaoData data = new Models.Cardapio.CardapioData.PorcaoData();
        // GET: Porcao
        public ActionResult Index()
        {
            return View();
        }

        // GET: Porcao/Details/5
        public ActionResult Detalhar(int id)
        {
            return View(data.GetPorcao(id));
        }

        public ActionResult Listar()
        {
            return View(data.GetLista());
        }

        // GET: Porcao/Create
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: Porcao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Models.Cardapio.Porcao collection, IFormFile pic)
        {
            try
            {
                if (pic != null)
                {
                    collection.imagem = pic.FileName;
                    var fileName = Path.Combine(he.WebRootPath + "\\uploadImages", Path.GetFileName(pic.FileName));
                    using (FileStream fs = new FileStream(fileName, FileMode.Create))
                    {
                        pic.CopyTo(fs);
                    }
                }
                data.PostPorcao(collection);

                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }

        // GET: Porcao/Edit/5
        public ActionResult Editar(int id)
        {
            return View(data.GetPorcao(id));
        }

        // POST: Porcao/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, Models.Cardapio.Porcao collection, IFormFile pic)
        {
            try
            {
                if (pic != null)
                {
                    collection.imagem = pic.FileName;
                    var fileName = Path.Combine(he.WebRootPath + "\\uploadImages", Path.GetFileName(pic.FileName));
                    using (FileStream fs = new FileStream(fileName, FileMode.Create))
                    {
                        pic.CopyTo(fs);
                    }
                }
                data.EditPorcao(collection, id);

                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }

        // GET: Porcao/Delete/5
        public ActionResult Deletar(int id)
        {
            return View(data.GetPorcao(id));
        }

        // POST: Porcao/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(int id, Models.Cardapio.Porcao collection)
        {
            try
            {
                data.DeletePorcao(collection, id);

                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }
    }
}