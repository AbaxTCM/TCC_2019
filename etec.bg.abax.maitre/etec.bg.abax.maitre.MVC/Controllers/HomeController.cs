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

        public IActionResult BemVindo()
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

        [HttpPost]
        public JsonResult ValidLogin(string email, string senha)
        {
            Session.Instance.Nome = null;
            Session.Instance.Funcao = null;
            Session.Instance.UserID = 0;

            string erro = "";
            bool sucesso;
            object resposta = null;
            Models.Pessoa.PessoaData.ClienteData data = new Models.Pessoa.PessoaData.ClienteData();
            Models.Pessoa.PessoaData.FuncionarioData funcData = new Models.Pessoa.PessoaData.FuncionarioData();
            Models.Estabelecimento.RestauranteData.RestauranteData restData = new Models.Estabelecimento.RestauranteData.RestauranteData();

            data.GetCliente(email, senha);
            if(Session.Instance.UserID == 0)
            {
                funcData.GetFuncionario(email, senha);
                if(Session.Instance.UserID == 0)
                {
                    restData.GetRestaurante(email, senha);
                    Session.Instance.Nome = "Admin";
                }
            }

            if (Session.Instance.UserID >= 1)
            {
                sucesso = true;
                resposta = new { sucesso };
                return Json(resposta);
            }
            else
            {
                sucesso = false;
                erro = "Login inválido";
                resposta = new { sucesso, erro };
                return Json(resposta);
            }
        }

        public JsonResult Cadastros(string email, string senha, string telefone, string nome, string cpf, string funcao, string endereco, string cnpj)
        {
            object retorno = null;
            bool sucesso;
            string erro = "Houve algum erro no cadastro",mensagem = "Cadastrado com sucesso";
            if (funcao == "cli")
            {
                try
                {
                    Models.Pessoa.Cliente cliente = new Models.Pessoa.Cliente();
                    Models.Pessoa.PessoaData.ClienteData data = new Models.Pessoa.PessoaData.ClienteData();
                    cliente.nome = nome;
                    cliente.eMail = email;
                    cliente.cpf = cpf;
                    cliente.fone = telefone;
                    cliente.senha = senha;
                    cliente.funcao = funcao;
                    data.PostCliente(cliente);
                    sucesso = true;
                    return Json(retorno = new { sucesso, mensagem });
                }
                catch { erro += " do cliente"; return Json(retorno = new { sucesso = false, erro }); }
            }
            else if (funcao == "rest")
            {
                try
                {
                    Models.Estabelecimento.Restaurante restaurante = new Models.Estabelecimento.Restaurante();
                    Models.Estabelecimento.RestauranteData.RestauranteData data = new Models.Estabelecimento.RestauranteData.RestauranteData();
                    restaurante.nome = nome;
                    restaurante.eMail = email;
                    restaurante.cnpj = cnpj;
                    restaurante.fone = telefone;
                    restaurante.endereco = endereco;
                    restaurante.funcao = funcao;
                    restaurante.senha = senha;
                    data.PostRestaurante(restaurante);
                    sucesso = true;
                    return Json(retorno = new { sucesso, mensagem });
                }
                catch { erro += " do restaurante"; return Json(retorno = new { sucesso = false, erro }); }
            }
            else if (funcao == "func")
            {
                try
                {
                    Models.Pessoa.Funcionario funcionario = new Models.Pessoa.Funcionario();
                    Models.Pessoa.PessoaData.FuncionarioData data = new Models.Pessoa.PessoaData.FuncionarioData();
                    funcionario.nome = nome;
                    funcionario.eMail = email;
                    funcionario.fone = telefone;
                    funcionario.funcao = funcao;
                    funcionario.senha = senha;
                    data.PostFuncionario(funcionario);
                    sucesso = true;
                    return Json(retorno = new { sucesso, mensagem });
                }
                catch { erro += " do funcionário"; return Json(retorno = new { sucesso = false, erro }); }
            }
            else
            {
                return Json(retorno = new { sucesso = false, erro });
            }
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
