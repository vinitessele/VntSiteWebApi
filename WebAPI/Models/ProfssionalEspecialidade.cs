using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace WebAPI.Models
{
    public class ProfssionalEspecialidade
    {
        private ILog Logger = LogManager.GetLogger(typeof(ProfssionalEspecialidade));

        public List<DtoProfssionalEspecialidade> listaprofissionalespecialidades()
        {
            Context db = new Context();
            return db.profssionalespecialidades.ToList();
        }

        internal void Atualizar(int id, DtoProfssionalEspecialidade profEspecialidade)
        {
            throw new NotImplementedException();

        }

        internal void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public void Gravar(DtoProfssionalEspecialidade profEspecialidade)
        {
            try
            {
                Logger.Info(profEspecialidade.id_especialidade);
                Context db = new Context();
                db.profssionalespecialidades.Add(profEspecialidade);
                Thread.Sleep(500);
                db.SaveChangesAsync();
            }catch(Exception ex)
            {
                Logger.Error("GravarProfissionaEspecialidade", ex.InnerException);
            }      
        }

        public DtoProfssionalEspecialidade profissionalespecialidade(int idEs, int idPe)
        {
            Context db = new Context();
            return db.profssionalespecialidades.Where(p=>p.id_especialidade==idEs && p.id_pessoa==idPe).FirstOrDefault();
        }
    }
}