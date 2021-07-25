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
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Telefone { get; set; }
        public string Telefone2 { get; set; }
        public DateTime? DataNascimento { get; set; }
    }
}
