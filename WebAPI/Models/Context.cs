using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Context : DbContext
    {
        public Context() : base("MyDbConnection")
        {
        }
        public DbSet<DtoPessoa> pessoas { get; set; }
        public DbSet<DtoEspecialidade> especialidades { get; set; }
        public DbSet<DtoProfssionalEspecialidade> profssionalespecialidades { get; set; }
    }
}