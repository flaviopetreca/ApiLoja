using ApiLoja.Models;
using ApiLoja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
namespace ApiLoja.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        readonly Context _context;
        readonly ClientesServices _service;


        public ValuesController(Context context)
        {
            _context = context;
            _service = new ClientesServices(_context);
        }

        //GET api/values
        [HttpGet]
        public string Get()
        {

            if (_service.Buscar().Count == 0)
            {
                List<Clientes> clientes = new List<Clientes>();

                clientes.Add(new Clientes()
                {
                    CPF = "22222222222",
                    DataNascimento = DateTime.Now,
                    Endereco = "rua bucarest, n8",
                    Nome = "Flavio Petreca dos Santos",
                    Email = "flavio@email.com",
                    Email2 = "flavio@email2.com",
                    Telefone = "11333333333",
                    Telefone2 = "11222222222"
                });

                clientes.Add(new Clientes()
                {
                    CPF = "22222222222",
                    DataNascimento = DateTime.Now,
                    Endereco = "rua Osasco, n8",
                    Nome = "Allan Rogério dos Santos",
                    Email = "allan@email.com",
                    Email2 = "allan@email2.com",
                    Telefone = "11444444444",
                    Telefone2 = "11555555555"
                });
                
                foreach (var item in clientes)
                {
                    _service.Inserir(item);
                }
            }
            //eturn service.Buscar();
            return "Passou!!";

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
