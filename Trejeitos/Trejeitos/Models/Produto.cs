﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trejeitos.Models
{
    public class Produto
    {
        public int produtoId  { get; set; }
        public string nome { get; set; }
        public string caminhoimg { get; set; }
        public string descricao { get; set; }
        public string colecao { get; set; }
        public string tamanho { get; set; }
        public string cor { get; set; }
        public Decimal preco { get; set; }
    }
}
