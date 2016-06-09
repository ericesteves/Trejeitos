using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trejeitos.Models;

namespace Trejeitos.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            using (LoginModel clilogin = new LoginModel())
            {
                Cliente cli = clilogin.Autenticar(form["email"], form["senha"]);

                if (cli == null)
                {
                    ViewBag.Mensagem = "Usuário ou senha inválidos";
                    return View(cli);
                }
                else
                {
                    List<Produto> carrinho = new List<Produto>();
                    Session["user"] = cli;
                    Session["nome"] = cli.nome;
                    Session["carrinho"] = carrinho;
                    Session["itens"] = carrinho.Count();
                }
            }
            return RedirectToAction("Inicio", "Inicio");
        }

        public ActionResult Sair()
        {
            Session.Remove("nome");
            return RedirectToAction("Inicio", "Inicio");
        }
    }
}