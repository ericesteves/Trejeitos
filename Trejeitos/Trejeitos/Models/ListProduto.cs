using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Trejeitos.Models
{
    public class ListProduto
    {
        public int codigo { get; set; }
        public string imagem { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string colecao { get; set; }
        public string tamanho { get; set; }
        public string cor { get; set; }
        public decimal preco { get; set; }
    }
}