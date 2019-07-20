using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CityFunc.Web.Models
{
    [Table("Municipio")]
    public class Municipio
    {
        [Key]
        [Required(ErrorMessage = "Id obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Favor selecionar UF.")]
        [StringLength(2, ErrorMessage = "Máximo 2 Caracteres")]
        public string UF { get; set; }

        [Required(ErrorMessage = "Favor inserir nome do municipio.")]
        public string Nome { get; set; }
    }
}