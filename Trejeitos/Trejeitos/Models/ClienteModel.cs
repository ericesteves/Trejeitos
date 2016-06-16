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
            SqlCommand sql = new SqlCommand(); //vagabunda
            sql.Connection = conn;
            sql.CommandText = "insert into Clientes values (@nome,@email,@senha,@rg,@cpf,@data_nascimento,@endereco,@cidade,@estado,@telefone)";
            sql.Parameters.AddWithValue("@nome", cli.nome);
            sql.Parameters.AddWithValue("@email", cli.email);
            sql.Parameters.AddWithValue("@senha", cli.senha);
            sql.Parameters.AddWithValue("@rg", cli.rg);
            sql.Parameters.AddWithValue("@cpf", cli.cpf);
            sql.Parameters.AddWithValue("@Data_nascimento", cli.data_nascimento);
            sql.Parameters.AddWithValue("@endereco", cli.endereco);
            sql.Parameters.AddWithValue("@cidade", cli.cidade);
            sql.Parameters.AddWithValue("@estado", cli.estado);
            sql.Parameters.AddWithValue("@telefone", cli.telefone);
            sql.ExecuteNonQuery();
        }

        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Clientes";
            cmd.Connection = conn;

            SqlDataReader clientes = cmd.ExecuteReader();
            while (clientes.Read())
            {
                Cliente cli = new Cliente();

                cli.clienteid = (int)clientes["clienteid"];
                cli.nome = (string)clientes["nome"];
                cli.email = (string)clientes["email"];
                cli.rg = (string)clientes["rg"];
                cli.cpf = (string)clientes["cpf"];
                cli.data_nascimento = (string)clientes["data_nascimento"];
                cli.endereco = (string)clientes["endereco"];
                cli.cidade = (string)clientes["cidade"];
                cli.estado = (string)clientes["estado"];
                cli.telefone = (string)clientes["telefone"];
                lista.Add(cli);
            }
            return lista;
        }

        public Cliente Editar(int id)
        {
            Cliente cli = new Cliente();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Clientes where clienteid = @id";
            cmd.Parameters.AddWithValue("@id", id);

            cmd.Connection = conn;

            SqlDataReader clientes = cmd.ExecuteReader();
            if (clientes.Read())
            { 
                cli.clienteid = (int)clientes["clienteid"];
                cli.nome = (string)clientes["nome"];
                cli.email = (string)clientes["email"];
                cli.rg = (string)clientes["rg"];
                cli.cpf = (string)clientes["cpf"];
                cli.data_nascimento = (string)clientes["data_nascimento"];
                cli.endereco = (string)clientes["endereco"];
                cli.cidade = (string)clientes["cidade"];
                cli.estado = (string)clientes["estado"];
                cli.telefone = (string)clientes["telefone"];
            }
            return cli;
        }

        public void Alterar(Cliente cli1)
        {
            SqlCommand sql = new SqlCommand(); //vagabunda
            sql.Connection = conn;
            sql.CommandText = "update Clientes set nome = @nome, email = @email,senha = @senha, rg = @rg, cpf = @cpf, data_nascimento = @data_nascimento, endereco = @endereco, cidade = @cidade, estado = @estado, telefone = @telefone where Clienteid = @id";
            sql.Parameters.AddWithValue("@nome", cli1.nome);
            sql.Parameters.AddWithValue("@email", cli1.email);
            sql.Parameters.AddWithValue("@senha", cli1.senha);
            sql.Parameters.AddWithValue("@rg", cli1.rg);
            sql.Parameters.AddWithValue("@cpf", cli1.cpf);
            sql.Parameters.AddWithValue("@Data_nascimento", cli1.data_nascimento);
            sql.Parameters.AddWithValue("@endereco", cli1.endereco);
            sql.Parameters.AddWithValue("@cidade", cli1.cidade);
            sql.Parameters.AddWithValue("@estado", cli1.estado);
            sql.Parameters.AddWithValue("@telefone", cli1.telefone);
            sql.Parameters.AddWithValue("@id", cli1.clienteid);
            sql.ExecuteNonQuery();
        }

        public void Excluir(int id)
        {
            SqlCommand sql = new SqlCommand(); //vagabunda
            sql.Connection = conn;
            sql.CommandText = "delete from Clientes where clienteid = @id";
            sql.Parameters.AddWithValue("@id", id);
            sql.ExecuteNonQuery();
        }
    }
}