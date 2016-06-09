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

        public ActionResult RemoveItem(int codigo)
        {
            List<Produto> lista = (List<Produto>)Session["carrinho"];
            lista.Remove(lista.Find(delegate(Produto p) { return p.produtoId == codigo; }));
            if(lista.Count() == 0)
            {
                ViewBag.Mensagem = "Opa, seu carrinho está vazio! Clique em 'Continuar Comprando' para retornar a pagina de produtos";
            }
            Session["carrinho"] = lista;

            return RedirectToAction("Carrinho");
        }


    }
}