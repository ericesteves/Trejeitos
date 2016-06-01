using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trejeitos.Models;

namespace Trejeitos.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        public ActionResult Inicio()
        {
                ListProdutoModel list = new ListProdutoModel();
                List<ListProduto> lista = list.ListarVitrine();

                return View(lista);
        }

        public ActionResult OrdenaPrecoDesc()
        {
            ListProdutoModel list = new ListProdutoModel();
            List<ListProduto> lista = new List<ListProduto>();
            lista = list.ListarVitrineDesc();

            return View("Inicio", lista);
        }

        public ActionResult OrdenaPrecoAsc()
        {
            ListProdutoModel list = new ListProdutoModel();
            List<ListProduto> lista = new List<ListProduto>();
            lista = list.ListarVitrineAsc();

            return View("Inicio", lista);
        }
        public ActionResult Carrinho()
        {
            return RedirectToAction("Carrinho", "Carrinho");
        }
    }
}