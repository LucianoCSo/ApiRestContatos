using APIRest_Contatos.Models;
using APIRest_Contatos.Services;
using Microsoft.AspNetCore.Mvc;
using System;
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
            if (person == null) return NotFound("O contato informado não existe.");
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post(Contato person)
        {
            try
            {
                if (person == null) return BadRequest("Erro ao tentar salvar um contato.");
                return new ObjectResult(_pessoaService.Create(person));
            }
            catch(Exception ex)
            {
                return BadRequest("Erro ao tentar salvar um contato. " + ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(Contato person)
        {
            try
            {
                if (person == null) return BadRequest("Erro ao tentar atualizar um contato.");
                return new ObjectResult(_pessoaService.Update(person));
            }
            catch(Exception ex)
            {
                return BadRequest("Erro ao tentar atualizar um contato. " + ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _pessoaService.Delete(id);
                return NoContent();
            }
            catch(Exception ex)
            {
                return BadRequest("Erro ao tentar excluir um contato. " + ex.Message);
            }
        }
    }
}
