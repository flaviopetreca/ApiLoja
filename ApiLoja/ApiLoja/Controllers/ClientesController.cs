using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLoja.Models;
using ApiLoja.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLoja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        readonly Context _context;
        readonly ClientesServices _service;
        public ClientesController(Context context)
        {
            _context = context;
            _service = new ClientesServices(_context);
        }
        // GET: api/Clientes
        [AllowAnonymous]
        [HttpGet]
        public List<Clientes> Get()
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
        [AllowAnonymous]
        [HttpGet("{id}")]
        public ActionResult<Clientes> Get(int id)
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

        [AllowAnonymous]
        [HttpPost]
        public void Post([FromBody] Clientes clientes)
        {
            try
            {

                _service.Inserir(clientes);

            }
            catch (System.Exception)
            {

                throw;
            }

        }

        // PUT: api/Clientes/5
        [AllowAnonymous]
        [HttpPut()]
        public void Put([FromBody] Clientes clientes)
        {
            try
            {

                _service.Editar(clientes);

            }
            catch (System.Exception)
            {

                throw;
            }
        }

        // DELETE: api/ApiWithActions/5
        [AllowAnonymous]
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
