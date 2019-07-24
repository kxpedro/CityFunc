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
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Favor selecionar UF.")]
        [StringLength(2, ErrorMessage = "Máximo 2 Caracteres")]
        [Display(Name = "Estado")]
        public string UF { get; set; }

        [Required(ErrorMessage = "Favor inserir nome do municipio.")]
        [Display(Name = "Cidade")]
        public string Nome { get; set; }
    }
}