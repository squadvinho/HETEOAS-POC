using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HATEOAS_POC.Models
{

    public class PessoaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
