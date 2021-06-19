using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLoja.Models;
using ApiLoja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLoja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelefonesController : ControllerBase
    {
        readonly Context _context;
        readonly TelefonesServices _service;
        public TelefonesController(Context context)
        {
            _context = context;
            _service = new TelefonesServices(_context);
        }
        // GET: api/Clientes
        [HttpGet]
        public List<Telefones> Get()
        {
            try
            {

                return _service.Buscar();

            }
            catch (System.Exception)
            {

                throw;
            }

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Telefones> Get(int id)
        {
            return _service.BuscarPorId(id);
        }

        // POST: api/Clientes
        [HttpPost]
        public void Post([FromBody] Telefones telefones)
        {
            try
            {

                _service.Inserir(telefones);

            }
            catch (System.Exception)
            {

                throw;
            }

        }

        // PUT: api/Clientes/5
        [HttpPut()]
        public void Put([FromBody] Telefones telefones)
        {
            try
            {

                _service.Editar(telefones);

            }
            catch (System.Exception)
            {

                throw;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int Id)
        {
            try
            {

                _service.Apagar(Id);

            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
