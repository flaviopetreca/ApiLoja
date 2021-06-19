using ApiLoja.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ApiLoja.Repository
{
    public class EmailsRepository
    {
        readonly Context _context;
        public EmailsRepository(Context context)
        {
            _context = context;
        }
        
        public List<Emails> Buscar()
        {
            return _context.Emails
                .ToList();
        }

        public Emails BuscarPorId(int id)
        {
            return _context.Emails
                .Where(e => e.Id == id)
                .FirstOrDefault();
        }

        public void Inserir(Emails email)
        {
            _context.Emails.Add(email);
            _context.SaveChanges();
        }

        public void Editar(Emails email)
        {
            var retorno = _context.Emails
                .Where(_ => _.Id == email.Id)
                .FirstOrDefault();

            retorno.Email = email.Email;

            _context.Emails.Update(retorno);
            _context.SaveChanges();
        }

        public void Apagar(int id)
        {
            var retorno = _context.Emails
                .Where(_ => _.Id == id)
                .FirstOrDefault();

            _context.Emails.Remove(retorno);
            _context.SaveChanges();
        }
    }
}
