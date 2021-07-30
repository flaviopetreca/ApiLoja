using ApiLoja.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ApiLoja.Repository
{
    public class ClientesRepository
    {
        readonly Context _context;
        public ClientesRepository(Context context)
        {
            _context = context;
        }

        public List<Clientes> Buscar()
        {
            return _context.Clientes
                .ToList();
        }

        public Clientes BuscarPorId(int id)
        {
            return _context.Clientes
                .Where(e => e.Id == id)
                .FirstOrDefault();
        }

        public void Inserir(Clientes clientes)
        {
            _context.Clientes.Add(clientes);
            _context.SaveChanges();
        }

        public void Editar(Clientes clientes)
        {
            var retorno = _context.Clientes
                .Where(_ => _.Id == clientes.Id)
                .FirstOrDefault();

            retorno.Nome = clientes.Nome;
            retorno.CPF = clientes.CPF;
            retorno.Endereco = clientes.Endereco;
            retorno.DataNascimento = clientes.DataNascimento;
            retorno.Email = clientes.Email;
            retorno.Email2 = clientes.Email2;
            retorno.Telefone = clientes.Telefone;
            retorno.Telefone2 = clientes.Telefone2;

            _context.Clientes.Update(retorno);
            _context.SaveChanges();
        }

        public void Apagar(int id)
        {
            var retorno = _context.Clientes
                .Where(_ => _.Id == id)
                .FirstOrDefault();

            _context.Clientes.Remove(retorno);
            _context.SaveChanges();
        }
    }
}
