﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace etec.bg.abax.maitre.MVC.Controllers
{
    public class PratoController : Controller
    {
        private readonly IHostingEnvironment he;
        public PratoController(IHostingEnvironment e)
        {
            he = e;
        }
        Models.Cardapio.CardapioData.PratoData data = new Models.Cardapio.CardapioData.PratoData();
        // GET: Prato
        public ActionResult Index()
        {
            return View();
        }

        // GET: Prato/Details/5
        public ActionResult Detalhar(int id)
        {
            return View(data.GetPrato(id));
        }

        public ActionResult Listar()
        {
            return View(data.GetLista());
        }

        // GET: Prato/Create
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: Prato/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Models.Cardapio.Prato collection, IFormFile pic)
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
                data.PostPrato(collection);

                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }

        // GET: Prato/Edit/5
        public ActionResult Editar(int id)
        {
            return View(data.GetPrato(id));
        }

        // POST: Prato/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, Models.Cardapio.Prato collection, IFormFile pic)
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
                data.EditPrato(collection, id);

                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }

        // GET: Prato/Delete/5
        public ActionResult Deletar(int id)
        {
            return View(data.GetPrato(id));
        }

        // POST: Prato/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(int id, Models.Cardapio.Prato collection)
        {
            try
            {
                data.DeletePrato(collection, id);

                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }
    }
}