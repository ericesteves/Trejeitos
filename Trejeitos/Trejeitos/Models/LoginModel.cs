using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


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
            }

            return cli;
        }
    }
}