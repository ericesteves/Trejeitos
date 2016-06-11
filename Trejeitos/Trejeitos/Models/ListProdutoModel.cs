using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Trejeitos.Models
{
    public class ListProdutoModel : Model
    {
        public List<ListProduto> ListarVitrine()
        {
            List<ListProduto> lista = new List<ListProduto>();
            SqlCommand sql = new SqlCommand();
            sql.Connection = conn;
            sql.CommandText = "select * from Produtos";
            SqlDataReader prods = sql.ExecuteReader();
            while (prods.Read())
            {
                ListProduto prod = new ListProduto();
                prod.codigo = (int)prods["codigo"];
                prod.imagem = (string)prods["imagem"];
                prod.nome = (string)prods["nome"];
                prod.descricao = (string)prods["descricao"];
                prod.colecao = (string)prods["colecao"];
                prod.tamanho = (string)prods["tamanho"];
                prod.cor = (string)prods["cor"];
                prod.preco = (decimal)prods["preco"];

                lista.Add(prod);
            }

            return lista;

        }

        public List<ListProduto> ListarVitrineDesc()
        {
            List<ListProduto> lista = new List<ListProduto>();
            SqlCommand sql = new SqlCommand();
            sql.Connection = conn;
            sql.CommandText = "select * from Produtos order by preco desc";
            SqlDataReader prods = sql.ExecuteReader();
            while (prods.Read())
            {
                ListProduto prod = new ListProduto();
                prod.codigo = (int)prods["codigo"];
                prod.imagem = (string)prods["imagem"];
                prod.nome = (string)prods["nome"];
                prod.descricao = (string)prods["descricao"];
                prod.colecao = (string)prods["colecao"];
                prod.tamanho = (string)prods["tamanho"];
                prod.cor = (string)prods["cor"];
                prod.preco = (decimal)prods["preco"];

                lista.Add(prod);
            }

            return lista;

        }
        public List<ListProduto> ListarVitrineAsc()
        {
            List<ListProduto> lista = new List<ListProduto>();
            SqlCommand sql = new SqlCommand();
            sql.Connection = conn;
            sql.CommandText = "select * from Produtos order by preco asc";
            SqlDataReader prods = sql.ExecuteReader();
            while (prods.Read())
            {
                ListProduto prod = new ListProduto();
                prod.codigo = (int)prods["codigo"];
                prod.imagem = (string)prods["imagem"];
                prod.nome = (string)prods["nome"];
                prod.descricao = (string)prods["descricao"];
                prod.colecao = (string)prods["colecao"];
                prod.tamanho = (string)prods["tamanho"];
                prod.cor = (string)prods["cor"];
                prod.preco = (decimal)prods["preco"];

                lista.Add(prod);
            }

            return lista;

        }
    }
}