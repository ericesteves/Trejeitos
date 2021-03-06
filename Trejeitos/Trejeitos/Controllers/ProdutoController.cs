﻿using System;
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
            prod.preco = decimal.Parse(form["preco"]);
           
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

        public ActionResult Editar(int codigo)
        {
            ProdutoModel prodmodel = new ProdutoModel();
            Produto prod = prodmodel.Buscar(codigo);
            TempData["prod"] = prod;
            return View("EditaProduto");
        }
        [HttpPost]
        public ActionResult AlterarProduto(FormCollection form)
        {
            Produto prod = new Produto();
            prod.codigo = int.Parse(form["codigo"]);
            prod.nome = form["nome"];
            prod.caminhoimg = form["imagem"];
            prod.descricao = form["descricao"];
            prod.colecao = form["colecao"];
            prod.tamanho = form["tamanho"];
            prod.cor = form["cor"];
            prod.preco = decimal.Parse(form["preco"]);

            ProdutoModel prodmodel = new ProdutoModel();
            prodmodel.Alterar(prod);

            return RedirectToAction("ListaProduto", "Produto");
        }

        public ActionResult Excluir(int codigo)
        {
            ProdutoModel prodmodel = new ProdutoModel();
            prodmodel.Excluir(codigo);
            return RedirectToAction("ListaProduto");
        }
    }
}