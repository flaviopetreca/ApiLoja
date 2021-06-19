using ApiLoja.Models;
using ApiLoja.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiLoja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        readonly Context _context;
        readonly EmailsServices _service;
        public EmailsController(Context context)
        {
            _context = context;
            _service = new EmailsServices(_context);
        }
        // GET: api/Clientes
        [HttpGet]
        public List<Emails> Get()
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

        // GET: api/Clientes/5
        [HttpGet("{id}")]
        public ActionResult<Emails> Get(int id)
        {
            try
            {

                return _service.BuscarPorId(id);

            }
            catch (System.Exception)
            {

                throw;
            }
        }

        // POST: api/Clientes
        [HttpPost]
        public void Post([FromBody] Emails emails)
        {
            try
            {

                _service.Inserir(emails);

            }
            catch (System.Exception)
            {

                throw;
            }

        }

        // PUT: api/Clientes/5
        [HttpPut()]
        public void Put([FromBody] Emails emails)
        {
            try
            {

                _service.Editar(emails);

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
