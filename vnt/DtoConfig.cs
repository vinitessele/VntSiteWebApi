using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace vnt
{
    [Table("config", Schema="public")]
    public class DtoConfig
    {
        [Key]
        public string campo { get; set; }
        public string valor { get; set; }
    }
}