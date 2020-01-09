using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIRest_Contatos.Models;
using APIRest_Contatos.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIRest_Contatos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TelefoneController : ControllerBase
    {
        public ITelefoneService _telefoneService;

        public TelefoneController(ITelefoneService telefoneService)
        {
            _telefoneService = telefoneService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_telefoneService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var telefone = _telefoneService.FindById(id);
            if (telefone == null) return NotFound("Telefone Não encontrado.");
            return Ok(telefone);
        }
        [HttpPost]
        public IActionResult Post(Telefones telefone)
        {
            try
            {
                if (telefone == null) return BadRequest("Erro ao tentar salvar um telefone.");
                return new ObjectResult(_telefoneService.Create(telefone));
            }
            catch(Exception ex)
            {
                return BadRequest("Erro ao tentar salvar um telefone. " + ex.Message);
            }
            
        }
        [HttpPut]
        public IActionResult Put(Telefones telefone)
        {
            try
            {
                if (telefone == null) return BadRequest("Erro ao tentar atualizar um telefone.");
                return new ObjectResult(_telefoneService.Update(telefone));
            }
            catch(Exception ex)
            {
                return BadRequest("Erro ao tentar atualizar um telefone." + ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _telefoneService.Delete(id);
                return NoContent();
            }
            catch(Exception ex)
            {
                return BadRequest("Erro ao tentar excluir um telefone." + ex.Message);
            }
        }
    }
}