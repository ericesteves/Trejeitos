using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Trejeitos.Models
{
    public class ProdutoModel : Model
    {
        public void Incluir(Produto prod)
        {
            SqlCommand sql = new SqlCommand();
            sql.Connection = conn;
            sql.CommandText = "insert into Produtos values (@nome,@imagem,@descricao,@colecao,@tamanho,@cor,@preco)";
            sql.Parameters.AddWithValue("@nome", prod.nome);
            sql.Parameters.AddWithValue("@imagem", prod.caminhoimg);
            sql.Parameters.AddWithValue("@descricao", prod.descricao);
            sql.Parameters.AddWithValue("@colecao", prod.colecao);
            sql.Parameters.AddWithValue("@tamanho", prod.tamanho);
            sql.Parameters.AddWithValue("@cor", prod.cor);
            sql.Parameters.AddWithValue("@preco", prod.preco);

            sql.ExecuteNonQuery();
        }

        public List<Produto> Listar()
        {
            List<Produto> lista = new List<Produto>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Produtos";
            cmd.Connection = conn;

            SqlDataReader produtos = cmd.ExecuteReader();
            while (produtos.Read())
            {
                Produto prod = new Produto();

                prod.produtoId = (int)produtos["codigo"];
                prod.nome = (string)produtos["nome"];
                prod.caminhoimg = (string)produtos["imagem"];
                prod.descricao = (string)produtos["descricao"];
                prod.colecao = (string)produtos["colecao"];
                prod.tamanho = (string)produtos["tamanho"];
                prod.cor = (string)produtos["cor"];
                prod.preco = (decimal)produtos["preco"];
                lista.Add(prod);
            }
            return lista;
        }

        public Produto Buscar(int codigo)
        {
            Produto produto = new Produto();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Produtos where codigo = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Connection = conn;

            SqlDataReader produtos = cmd.ExecuteReader();
            if (produtos.Read())
            {
                produto.produtoId = (int)produtos["codigo"];
                produto.nome = (string)produtos["nome"];
                produto.caminhoimg = (string)produtos["imagem"];
                produto.descricao = (string)produtos["descricao"];
                produto.colecao = (string)produtos["colecao"];
                produto.tamanho = (string)produtos["tamanho"];
                produto.cor = (string)produtos["cor"];
                produto.preco = (int)produtos["preco"];
            }
            return produto;
        }
    }
}