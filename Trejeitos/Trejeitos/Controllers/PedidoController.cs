using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trejeitos.Controllers
{
    public class PedidoController : Controller
    {
        // GET: Pedido
        public ActionResult Pedido()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalculaParcela(FormCollection form)
        {
            decimal total = (decimal)(Session["total"]);
            decimal parcela = 0;
            parcela = total / decimal.Parse(form["parcela"]);
            ViewBag.parcela = parcela;
            TempData["cartao"] = form["cartao"];
            TempData["nome"] = form["nome"];
            TempData["mes"] = form["mes"];
            TempData["ano"] = form["ano"];


            return View("Pedido");
        }
    }
}