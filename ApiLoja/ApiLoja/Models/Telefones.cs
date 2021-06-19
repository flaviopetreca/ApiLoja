using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoja.Models
{
    public class Telefones
    {
        [Key]
        public int Id { get; set; }
        public string numeroTelefone { get; set; }
    }

}
