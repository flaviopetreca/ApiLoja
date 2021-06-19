using ApiLoja.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ApiLoja.Repository
{
    public class TelefonesRepository
    {
        readonly Context _context;
        public TelefonesRepository(Context context)
        {
            _context = context;
        }


        public List<Telefones> Buscar()
        {
            return _context.Telefones
                .ToList();
        }

        public Telefones BuscarPorId(int id)
        {
            return _context.Telefones
                .Where(e => e.Id == id)
                .FirstOrDefault();
        }

        public void Inserir(Telefones telefones)
        {
            _context.Telefones.Add(telefones);
            _context.SaveChanges();
        }

        public void Editar(Telefones telefones)
        {
            var retorno = _context.Telefones
                .Where(_ => _.Id == telefones.Id)
                .FirstOrDefault();

            retorno.numeroTelefone = telefones.numeroTelefone;

            _context.Telefones.Update(retorno);
            _context.SaveChanges();
        }

        public void Apagar(int id)
        {
            var retorno = _context.Telefones
                .Where(_ => _.Id == id)
                .FirstOrDefault();

            _context.Telefones.Remove(retorno);
            _context.SaveChanges();
        }
    }
}

