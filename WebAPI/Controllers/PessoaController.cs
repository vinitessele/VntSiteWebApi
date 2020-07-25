using log4net;
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
        private ILog Logger = LogManager.GetLogger(typeof(PessoaController));
        private static List<DtoPessoa> pessoas = new List<DtoPessoa>();


        public List<DtoPessoa> Get()
        {
            Pessoa pessoa = new Pessoa();
            return pessoa.getlistapessoas();
        }
        public List<DtoPessoa> GetPessoaTipoPessoa(int TipoPessoa)
        {
            Pessoa pessoa = new Pessoa();
            return pessoa.getPessoaTp(TipoPessoa);
        }
        public DtoPessoa GetPessoaID(int id)
        {
            Pessoa pessoa = new Pessoa();
            return pessoa.getPessoaId(id);
        }
        public DtoPessoa GetPessoalEmail(string email)
        {
            Pessoa pessoa = new Pessoa();
            return pessoa.getPessoaEmail(email);
        }

        public DtoPessoa GetPessoaCPF(string cpf)
        {
            Pessoa _pessoa = new Pessoa();
            return _pessoa.getPessoaCPF(cpf);
        }

        public void Post([FromBody] DtoPessoa pessoa)
        {
            Pessoa p = new Pessoa();
            p.Gravar(pessoa);
            //if (!string.IsNullOrEmpty(nome))
            //    pessoas.Add(new DtoPessoa(nome));
        }
        public void Put(int id, [FromBody] DtoPessoa pessoa)
        {
            Pessoa _pessoa = new Pessoa();
            _pessoa.Atualizar(id, pessoa);
        }
        public void delete(int id)
        {
            Pessoa _pessoa = new Pessoa();
            _pessoa.Deletar(id);
        }
    }
}
