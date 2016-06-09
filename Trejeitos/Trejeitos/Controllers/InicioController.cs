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
            if(!(Session["carrinho"] == null))
            {
                List<Produto> sessao = (List<Produto>)Session["carrinho"];
                Session["itens"] = sessao.Count();
            }

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
        [HttpGet]
        public ActionResult Comprar(int codigo)
        {
            Produto prod = new ProdutoModel().Buscar(codigo);
            List<Produto> lista = (List<Produto>)Session["carrinho"];
            lista.Add(prod);
            Session["carrinho"] = lista;

            return RedirectToAction("Carrinho", "Carrinho");
        }
    }
}