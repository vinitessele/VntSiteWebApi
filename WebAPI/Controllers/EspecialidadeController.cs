using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class EspecialidadeController : ApiController
    {
        private static List<DtoEspecialidade> especialidades = new List<DtoEspecialidade>();

        public List<DtoEspecialidade> Get()
        {
            Especialidade especialidade = new Especialidade();
            return especialidade.listaEspecialidades();
        }
    }
}
