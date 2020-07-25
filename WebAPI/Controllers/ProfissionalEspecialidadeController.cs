using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ProfissionalEspecialidadeController : ApiController
    {
        private static List<DtoProfssionalEspecialidade> profissionalespecialidades = new List<DtoProfssionalEspecialidade>();

        public List<DtoProfssionalEspecialidade> Get()
        {
            ProfssionalEspecialidade _profissionalespecialidade = new ProfssionalEspecialidade();
            return _profissionalespecialidade.listaprofissionalespecialidades();
        }
        public DtoProfssionalEspecialidade GetProfissionalEspecialidade(int idEs, int idPe)
        {
            ProfssionalEspecialidade _profissionalespecialidade = new ProfssionalEspecialidade();
            return _profissionalespecialidade.profissionalespecialidade(idEs,idPe);
        }
        public void Post([FromBody] DtoProfssionalEspecialidade profEspecialidade)
        {
            ProfssionalEspecialidade _profissionalespecialidade = new ProfssionalEspecialidade();
            _profissionalespecialidade.Gravar(profEspecialidade);
        }
        public void Put(int id, [FromBody] DtoProfssionalEspecialidade profEspecialidade)
        {
            ProfssionalEspecialidade _profissionalespecialidade = new ProfssionalEspecialidade();
            _profissionalespecialidade.Atualizar(id, profEspecialidade);
        }
        public void delete(int id)
        {
            ProfssionalEspecialidade _profissionalespecialidade = new ProfssionalEspecialidade();
            _profissionalespecialidade.Deletar(id);
        }
    }
}
