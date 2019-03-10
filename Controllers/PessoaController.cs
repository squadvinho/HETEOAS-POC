using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HATEOAS_POC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HATEOAS_POC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        // GET api/pessoas
        [HttpGet(Name = "get-pessoas")]
        public ActionResult<IEnumerable<PessoaModel>> Get()
        {
            return new PessoaModel[]
            {
                new PessoaModel
                {
                    Id=1,
                    Nome="Abdala"
                },
                new PessoaModel
                {
                    Id=2,
                    Nome="Rafael"
                }
            };
        }

        // GET api/pessoas/5
        [HttpGet("{id}",Name = "get-pessoa")]
        public ActionResult<PessoaModel> Get(int id)
        {
            return new PessoaModel
            {
                Id=id,
                Nome="Generico"
            };
        }

        // POST api/pessoas
        [HttpPost(Name = "create-pessoa")]
        public void Post([FromBody] PessoaModel pessoa)
        {
        }

        // PUT api/pessoas/5
        [HttpPut("{id}",Name = "update-pessoa")]
        public void Put(int id, [FromBody] PessoaModel pessoa)
        {
        }

        // DELETE api/pessoas/5
        [HttpDelete("{id}",Name="delete-pessoa")]
        public void Delete(int id)
        {
        }
    }
}
