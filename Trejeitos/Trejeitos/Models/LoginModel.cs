using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trejeitos.Models
{
    public class LoginModel : Model
    {
        public Cliente Autenticar(string email, string senha)
        {
            Cliente cli = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Clientes where email = @email  and senha = @senha";

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            SqlDataReader login = cmd.ExecuteReader();

            if (login.Read())
            {
                cli = new Cliente();
                cli.nome = (string)login["nome"];
                cli.email = (string)login["email"];
                cli.senha = (string)login["senha"];
                cli.rg = (string)login["rg"];
                cli.cpf = (string)login["cpf"];
                cli.data_nascimento = (string)login["data_nascimento"];
                cli.endereco = (string)login["endereco"];
                cli.cidade = (string)login["cidade"];
                cli.estado = (string)login["estado"];
                cli.telefone = (string)login["telefone"];
            }

            return cli;
        }
    }
}