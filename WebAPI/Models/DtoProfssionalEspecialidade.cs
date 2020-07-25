using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    [Table("profissionalespecialidade", Schema = "public")]
    public class DtoProfssionalEspecialidade
    {
        [Key]
        public int id { get; set; }
        public int id_especialidade { get; set; }
        public int id_pessoa { get; set; }
    }
}