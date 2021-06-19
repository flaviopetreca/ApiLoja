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
        
        //readonly Context _context;
        //readonly EmailsServices _service;
        //readonly ClientesServices _Cservice;
        //readonly TelefonesServices _Tservice;
        //readonly ClienteContatoServices _CCservice;
        
        public ValuesController(Context context)
        {
            //_context = context;
            //_service = new EmailsServices(_context);
            //_Cservice = new ClientesServices(_context);
            //_Tservice = new TelefonesServices(_context);
            //_CCservice = new ClienteContatoServices(_context);
        }

        //GET api/values
        [HttpGet]
        public string Get()
        {

            //Clientes cliente = new Clientes()
            //{
            //    CPF = "22222222222",
            //    DataNascimento = DateTime.Now,
            //    Endereco = "rua bucarest, n8",
            //    NomeCliente = "Flavio Petreca dos Santos"
            //};


            //Emails email = new Emails()
            //{
            //    Email = "flaviopetreca@hotmail.com"
            //};

            //Telefones telefone = new Telefones()
            //{
            //    numeroTelefone = "11999999999"
            //};

            //ClientesContato clienteContato = new ClientesContato()
            //{
            //    IdCliente = 1,
            //    IdEmail = 2,
            //    IdTelefone = 2            };


            //_service.Inserir(email);
            //_Cservice.Inserir(cliente);
            //_Tservice.Inserir(telefone);
            //_CCservice.Inserir(clienteContato);



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
