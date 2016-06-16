using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trejeitos.Models;

namespace Trejeitos.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Cliente()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirCliente(FormCollection form)
        {
            Cliente cli = new Cliente();
            cli.nome = form["nome"];
            cli.email = form["email"];
            cli.rg = form["rg"];
            cli.cpf = form["cpf"];
            cli.senha = form["senha"];
            cli.data_nascimento = form["data_nascimento"];
            cli.cidade = form["cidade"];
            cli.estado = form["estado"];
            cli.endereco = form["endereco"];
            cli.telefone = form["telefone"];

            ClienteModel climodel = new ClienteModel();
                climodel.Incluir(cli);

            return RedirectToAction("Inicio", "Inicio");
        }

        public ActionResult ListaCliente()
        {
            ClienteModel climodel = new ClienteModel();
            List<Cliente> lista = climodel.Listar();

            return View(lista);
        }

        public ActionResult Editar(int id)
        {
            ClienteModel climodel = new ClienteModel();
            Cliente cliente = climodel.Editar(id);
            TempData["cliente"] = cliente;
            return View("Editar");
        }

        public ActionResult Excluir(int id)
        {
            ClienteModel climodel = new ClienteModel();
            climodel.Excluir(id);
            return RedirectToAction("ListaCliente");
        }

        [HttpPost]
        public ActionResult Alterar(FormCollection form1)
        {
            Cliente cli1 = new Cliente();
            cli1.clienteid = int.Parse(form1["clienteid"]);
            cli1.nome = form1["nome"];
            cli1.email = form1["email"];
            cli1.rg = form1["rg"];
            cli1.cpf = form1["cpf"];
            cli1.senha = form1["senha"];
            cli1.data_nascimento = form1["data_nascimento"];
            cli1.cidade = form1["cidade"];
            cli1.estado = form1["estado"];
            cli1.endereco = form1["endereco"];
            cli1.telefone = form1["telefone"];

            using (ClienteModel climodel = new ClienteModel())
            {
                climodel.Alterar(cli1);
            }

            return RedirectToAction("ListaCliente", "Cliente");
        }
    }
}