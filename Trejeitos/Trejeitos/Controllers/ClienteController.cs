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
    }
}