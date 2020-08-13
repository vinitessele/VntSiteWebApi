using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Contrato
    {
        private ILog Logger = LogManager.GetLogger(typeof(Pessoa));

        public List<DtoContrato> getContratante(int id_contratante)
        {
            try
            {
                Context db = new Context();
                return db.contratos.Where(p => p.id_contratante == id_contratante).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error("listacontratos", ex.InnerException);
                throw ex;
            }
        }

        public List<DtoContrato> getProfissional(int id_profissional)
        {
            try
            {
                Context db = new Context();
                return db.contratos.Where(p => p.id_profissional == id_profissional).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error("listacontratos", ex.InnerException);
                throw ex;
            }
        }

        public void Gravar(DtoContrato contrato)
        {
            try
            {
                Context db = new Context();
                db.contratos.Add(contrato);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Logger.Error("GarvarContratos", ex.InnerException);
                throw ex;
            }
        }
        public void Atualizar(int id, DtoContrato contrato)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }
    }
}