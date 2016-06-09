using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trejeitos.Models;

namespace Trejeitos.Controllers
{
    public class CarrinhoController : Controller
    {
        // GET: Carrinho
        public ActionResult Carrinho()
        {
            List<Produto> lista = (List<Produto>)Session["carrinho"];

            return View(lista);
        }
    }
}