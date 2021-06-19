using ApiLoja.Models;
using ApiLoja.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoja.Services
{
    public class TelefonesServices
    {
        readonly Context _context;
        readonly TelefonesRepository _repository;
        public TelefonesServices(Context context)
        {
            _context = context;
            _repository = new TelefonesRepository(_context);
        }

        public void Inserir(Telefones telefone)
        {
            try
            {
                _repository.Inserir(telefone);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public List<Telefones> Buscar()
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

        public Telefones BuscarPorId(int id)
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

        public void Editar(Telefones telefone)
        {
            try
            {
                _repository.Editar(telefone);
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

    

