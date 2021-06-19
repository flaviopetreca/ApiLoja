using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoja.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public DateTime? DataNascimento { get; set; }
    }
}
