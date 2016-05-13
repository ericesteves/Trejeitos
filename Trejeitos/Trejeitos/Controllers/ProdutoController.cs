using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trejeitos.Models;

namespace Trejeitos.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Produto()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirProduto(FormCollection form)
        {
            Produto prod = new Produto();
            prod.nome = form["nome"];
            prod.caminhoimg = form["imagem"];
            prod.descricao = form["descricao"];
            prod.colecao = form["colecao"];
            prod.tamanho = form["tamanho"];
            prod.cor = form["cor"];
            prod.preco = Convert.ToDecimal(form["preco"]);
           
            ProdutoModel prodmodel = new ProdutoModel();
            prodmodel.Incluir(prod);

            return RedirectToAction("Inicio", "Inicio");
        }

        public ActionResult ListaProduto()
        {
            ProdutoModel prodmodel = new ProdutoModel();
            List<Produto> lista = prodmodel.Listar();

            return View(lista);
        }
    }
}