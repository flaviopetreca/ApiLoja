using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoja.Models
{
    public class ClientesContato
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Emails")]
        public int IdEmail { get; set; }
        
        [ForeignKey("Telefones")]
        public int IdTelefone { get; set; }

        [ForeignKey("Clientes")]
        public int IdCliente { get; set; }
        
        public virtual Clientes Clientes { get; set; }
        public virtual Emails Emails { get; set; }
        public virtual Telefones Telefones { get; set; }

    }

}
