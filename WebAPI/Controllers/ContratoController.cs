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
    public class ContratoController : ApiController
    {
        private ILog Logger = LogManager.GetLogger(typeof(PessoaController));
        private static List<DtoContrato> contratos = new List<DtoContrato>();

        public List<DtoContrato> getIDContratante(int id_contratante)
        {
            Contrato _contrato = new Contrato();
            return _contrato.getContratante(id_contratante);
        }
        public List<DtoContrato> getIDProfissional(int id_profissional)
        {
            Contrato _contrato = new Contrato();
            return _contrato.getProfissional(id_profissional);
        }
        public void Post([FromBody] DtoContrato contrato)
        {
            Contrato _contrato = new Contrato();
            _contrato.Gravar(contrato);
        }
        public void Put(int id, [FromBody] DtoContrato contrato)
        {
            Contrato _contrato = new Contrato();
            _contrato.Atualizar(id, contrato);
        }
        public void delete(int id)
        {
            Contrato _contrato = new Contrato();
            _contrato.Deletar(id);
        }
    }
}
