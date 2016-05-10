using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Trejeitos.Models
{
    public class ClienteModel : Model
    {
        public void Incluir(Cliente cli)
        {
            SqlCommand sql = new SqlCommand();
            sql.Connection = conn;
            sql.CommandText = "insert into Clientes values (@nome,@email,@senha,@cpf,@rg,@data_nascimento,@endereco,@cidade,@estado,@telefone)";
            sql.Parameters.AddWithValue("@nome", cli.nome);
            sql.Parameters.AddWithValue("@email", cli.email);
            sql.Parameters.AddWithValue("@senha", cli.senha);
            sql.Parameters.AddWithValue("@cpf", cli.cpf);
            sql.Parameters.AddWithValue("@rg", cli.rg);
            sql.Parameters.AddWithValue("@Data_nascimento", cli.data_nascimento);
            sql.Parameters.AddWithValue("@endereco", cli.endereco);
            sql.Parameters.AddWithValue("@cidade", cli.cidade);
            sql.Parameters.AddWithValue("@estado", cli.estado);
            sql.Parameters.AddWithValue("@telefone", cli.telefone);
            sql.ExecuteNonQuery();
        }
    }
}