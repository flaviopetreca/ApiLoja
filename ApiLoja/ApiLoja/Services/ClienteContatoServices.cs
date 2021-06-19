using ApiLoja.Models;
using ApiLoja.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoja.Services
{
    public class ClienteContatoServices
    {
        readonly Context _context;
        readonly ClientesContatoRepository _repository;
        public ClienteContatoServices(Context context)
        {
            _context = context;
            _repository = new ClientesContatoRepository(_context);
        }

        public void Inserir(ClientesContato clientes)
        {
            try
            {
                _repository.Inserir(clientes);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public List<ClientesContato> Buscar()
        {
            try
            {
                return _repository.Buscar();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public ClientesContato BuscarPorId(int id)
        {
            try
            {
                return _repository.BuscarPorId(id);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Editar(ClientesContato clientes)
        {
            try
            {
                _repository.Editar(clientes);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Apagar(int id)
        {
            try
            {
                _repository.Apagar(id);
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
