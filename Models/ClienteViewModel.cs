using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendasMvc.Models
{
    public class ClienteViewModel
    {
        public int Id {get; set; }
        public string Empresa {get; set; }
        public int Telefone {get; set; }
        public string Email {get; set;}
        public string Comprador {get; set; }
        public int Data {get; set; }
        public string Nome { get; set; }
        //Vendedor.Nome para puxar o nome do vendedor do models
    }
}