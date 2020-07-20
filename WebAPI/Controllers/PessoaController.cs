using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class PessoaController : ApiController
    {
        private static List<DtoPessoa> pessoas = new List<DtoPessoa>();

        public List<DtoPessoa> Get()
        {
            Context db = new Context();
           
            return db.pessoas.ToList();
        }
        public void Post(string nome)
        {
            //if (!string.IsNullOrEmpty(nome))
            //    pessoas.Add(new DtoPessoa(nome));
        }
    }
}
