using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Especialidade
    {
        internal List<DtoEspecialidade> listaEspecialidades()
        {
            Context db = new Context();
            return db.especialidades.ToList();
        }
    }
}