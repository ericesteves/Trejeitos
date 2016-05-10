using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trejeitos.Models
{
    public class Cliente
    {
        public int clienteid { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public String data_nascimento { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string telefone { get; set; }
    }
}