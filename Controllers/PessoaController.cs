using APIRest_Contatos.Models;
using APIRest_Contatos.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APIRest_Contatos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {

        private IPessoaService _pessoaService;
        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pessoaService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _pessoaService.FindById(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Pessoa person)
        {
            if (person == null) return BadRequest();
            return new ObjectResult(_pessoaService.Create(person));
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Pessoa person)
        {
            if (person == null) return BadRequest();
            return new ObjectResult(_pessoaService.Update(person));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _pessoaService.Delete(id);
            return NoContent();
        }
    }
}
