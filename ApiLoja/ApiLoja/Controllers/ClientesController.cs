using System;
using System.Collections.Generic;
using System.Globalization;
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
        public void Post([FromBody] dynamic clientes)
        {
            try
            {
                var cliente = MontarCliente(clientes);
                _service.Inserir(cliente);

            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        // PUT: api/Clientes/5
        [AllowAnonymous]
        [HttpPut()]
        public void Put([FromBody] dynamic clientes)
        {
            try
            {
                var cliente = MontarCliente(clientes);
               
                _service.Editar(cliente);

            }
            catch (System.Exception ex)
            {

                throw new Exception(ex.Message);
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

        private Clientes MontarCliente(dynamic clientes)
        {
            string data = clientes.dataNascimento;
            return new Clientes()
            {
                Id = clientes.id == null ? 0 : clientes.id,
                Nome = clientes.nome,
                CPF = clientes.cpf,
                DataNascimento = ConverterData(data),
                Email = clientes.email,
                Email2 = clientes.email2,
                Endereco = clientes.endereco,
                Telefone = clientes.telefone,
                Telefone2 = clientes.telefone2
            };
        }

        private DateTime ConverterData(string data)
        {
            var dataRetorno = DateTime.ParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            return dataRetorno;
        }
    }
}
