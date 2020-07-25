using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    [Table("especialidade", Schema = "public")]
    public class DtoEspecialidade
    {
        [Key]
        public int id { get; set; }
        public string descricao { get; set; }
    }
}