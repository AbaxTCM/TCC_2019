using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using etec.bg.abax.maitre.MVC.Models;

namespace etec.bg.abax.maitre.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pessoa()
        {
            return View();
        }

        public IActionResult Cardapio()
        {
            return View();
        }

        public IActionResult Reserva()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        
        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Validar(Models.Pessoa.LoginRegistro collection)
        {
            string email = collection.eMail, senha = collection.senha;
            return View();
        }

        public IActionResult Senha()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
