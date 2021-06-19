using ApiLoja.Models;
using ApiLoja.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoja.Services
{
    public class ClientesServices
    {
        readonly Context _context;
        readonly ClientesRepository _repository;
        public ClientesServices(Context context)
        {
            _context = context;
            _repository = new ClientesRepository(_context);
        }

        public void Inserir(Clientes clientes)
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

        public List<Clientes> Buscar()
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

        public Clientes BuscarPorId(int id)
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

        public void Editar(Clientes clientes)
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
