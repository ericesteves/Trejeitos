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
                    Session["user"] = cli;
                }
            }
            return RedirectToAction("Inicio", "Inicio");
        }

        public ActionResult Sair()
        {
            Session.Remove("user");
            return RedirectToAction("Login");
        }
    }
}