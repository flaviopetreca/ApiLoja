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
    public class ClienteContatoController : ControllerBase
    {
        readonly Context _context;
        readonly ClienteContatoServices _service;
        public ClienteContatoController(Context context)
        {
            _context = context;
            _service = new ClienteContatoServices(_context);
        }
        // GET: api/Clientes

        [HttpGet]
        public List<ClientesContato> Get()
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
        public ActionResult<ClientesContato> Get(int id)
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
        public void Post([FromBody] ClientesContato clientesContato)
        {
            try
            {

                _service.Inserir(clientesContato);

            }
            catch (System.Exception)
            {

                throw;
            }

        }

        // PUT: api/Clientes/5
        [HttpPut()]
        public void Put( [FromBody] ClientesContato clientesContato)
        {
            try
            {

                _service.Editar(clientesContato);

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
