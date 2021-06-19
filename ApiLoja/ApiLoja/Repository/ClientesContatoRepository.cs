using ApiLoja.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ApiLoja.Repository
{
    public class ClientesContatoRepository
    {
        readonly Context _context;
        public ClientesContatoRepository(Context context)
        {
            _context = context;
        }

        public List<ClientesContato> Buscar()
        {
            return _context.ClientesContato
                .Include(c => c.Clientes)
                .Include(e => e.Emails)
                .Include(t => t.Telefones)
                .ToList();
        }

        public ClientesContato BuscarPorId(int id)
        {
            return _context.ClientesContato
              .Include(c => c.Clientes)
              .Include(e => e.Emails)
              .Include(t => t.Telefones)
              .Where(c => c.Id == id)
              .FirstOrDefault();
        }
        public void Inserir(ClientesContato clientesContato)
        {
            _context.ClientesContato.Add(clientesContato);
            _context.SaveChanges();
        }

          public void Editar(ClientesContato clientesContato)
        {
            var retorno = _context.ClientesContato
                .Where(_ => _.Id == clientesContato.Id)
                .FirstOrDefault();

            retorno.IdCliente = clientesContato.IdCliente;
            retorno.IdEmail = clientesContato.IdEmail;
            retorno.IdTelefone = clientesContato.IdTelefone;

            _context.ClientesContato.Update(retorno);
            _context.SaveChanges();
        }

        public void Apagar(int id)
        {
            var retorno = _context.ClientesContato
                .Where(_ => _.Id == id)
                .FirstOrDefault();

            _context.ClientesContato.Remove(retorno);
            _context.SaveChanges();
        }
    }
}
