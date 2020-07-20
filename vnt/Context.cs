using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace vnt
{
    public class Context : DbContext
    {
        public Context() : base("MyDbConnection")
        {
        }
        public DbSet<DtoConfig> Configuracao { get; set; }
    }
}