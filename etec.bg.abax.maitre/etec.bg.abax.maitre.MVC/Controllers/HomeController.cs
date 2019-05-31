using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using etec.bg.abax.maitre.MVC.Models;
using static etec.bg.abax.maitre.MVC.Program;

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
            Models.Pessoa.PessoaData.ClienteData data = new Models.Pessoa.PessoaData.ClienteData();
            data.GetCliente(email, senha);
            if(Session.Instance.UserID < 1)
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View(nameof(Menu));
            }
        }

        [HttpPost]
        public JsonResult ValidLogin(string email, string senha)
        {
            string erro = "";
            Models.Pessoa.PessoaData.ClienteData data = new Models.Pessoa.PessoaData.ClienteData();
            data.GetCliente(email, senha);
            if (Session.Instance.UserID >= 1)
            {
                return Json("'Success':'true'");
            }
            else
            {
                erro = "Login inválido";
                return Json(String.Format("'Success':'false','Error':'{0}'", erro));
            }
        }

        public IActionResult Cadastrar(Models.Pessoa.LoginRegistro collection)
        {
            Models.Pessoa.Cliente cliente = new Models.Pessoa.Cliente();
            Models.Pessoa.PessoaData.ClienteData data = new Models.Pessoa.PessoaData.ClienteData();
            cliente.nome = collection.nome;
            cliente.eMail = collection.eMail;
            cliente.cpf = collection.cpf;
            cliente.fone = collection.telefone;
            cliente.senha = collection.senha;
            cliente.funcao = "cli";

            data.PostCliente(cliente);

            return View(nameof(Index));
        }

        public IActionResult Sair()
        {
            Session.Instance.Funcao = null;
            Session.Instance.UserID = 0;

            return View(nameof(Index));
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
