using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trejeitos.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult Carrinho()
        {
            return RedirectToAction("Carrinho", "Carrinho");
        }
    }
}