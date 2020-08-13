using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    [Table("contrato", Schema = "public")]
    public class DtoContrato
    {
        [Key]
        public int id { get; set; }
        public int id_profissional { get; set; }
        public int id_contratante { get; set; }
        public DateTime dt_record { get; set; }
        public string status { get; set; }
        public DateTime dt_aceite { get; set; }
        public string observacao { get; set; }


    }
}