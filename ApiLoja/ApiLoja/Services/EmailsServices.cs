using ApiLoja.Models;
using ApiLoja.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoja.Services
{
    public class EmailsServices
    {
        readonly Context _context;
        readonly EmailsRepository _repository;
        public EmailsServices(Context context)
        {
            _context = context;
            _repository = new EmailsRepository(_context);
        }

        public void Inserir(Emails email)
        {
            try
            {
                _repository.Inserir(email);
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public List<Emails> Buscar()
        {
            try
            {
                return  _repository.Buscar();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public Emails BuscarPorId(int id)
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

        public void Editar(Emails email)
        {
            try
            {
                _repository.Editar(email);
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
