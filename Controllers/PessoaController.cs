using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace APIRest_Contatos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Luciano", "Kelviane" };
        }

        [HttpGet]
        public string Get(long id)
        {
            return "Value";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {

        }
    }
}
