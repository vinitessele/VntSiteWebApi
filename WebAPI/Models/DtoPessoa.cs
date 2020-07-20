﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    [Table("pessoa", Schema = "public")]
    public class DtoPessoa
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
    }
}