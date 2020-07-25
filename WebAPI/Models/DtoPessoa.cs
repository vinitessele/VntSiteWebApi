using System;
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
        public string cpf { get; set; }
        public DateTime? dt_nascimento { get; set; }
        public string sexo { get; set; }
        public string celular { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string observacao { get; set; }
        public string domingo { get; set; }
        public string domingohoras { get; set; }
        public string segunda { get; set; }
        public string segundahoras { get; set; }
        public string terca { get; set; }
        public string tercahoras { get; set; }
        public string quarta { get; set; }
        public string quartahoras { get; set; }
        public string quinta { get; set; }
        public string quintahoras { get; set; }
        public string sexta { get; set; }
        public string sextahoras { get; set; }
        public string sabado { get; set; }
        public string sabadohoras { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public int? tp_login { get; set; }
        public byte[] img_usuario { get; set; }
        public string cad_aprovado { get; set; }
        public string valor_hora { get; set; }
        public string especialidade { get; set; }
        public double? avaliacao { get; set; }
    }
}