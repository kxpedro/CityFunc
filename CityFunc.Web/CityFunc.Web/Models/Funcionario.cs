using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CityFunc.Web.Models
{
    [Table("Funcionario")]
    public class Funcionario
    {
        [Key]
        [Required(ErrorMessage = "Id obrigatório")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Favor informar Nome Completo.")]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Favor informar Telefone.")]        
        [MinLength(10, ErrorMessage = "Mínimo 10 Caracteres")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Favor informar CPF.")]        
        [MinLength(11, ErrorMessage = "Mínimo 11 Caracteres")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }
        
        [Required(ErrorMessage = "Favor informar CEP.")]        
        [MinLength(8, ErrorMessage = "Mínimo 8 Caracteres")]
        [Display(Name = "CEP")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Favor informar Endereço.")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Favor informar Numero.")]
        [Display(Name = "Número")]
        [MinLength(1, ErrorMessage = "Mínimo 1 Caracteres")]
        public string Numero { get; set; }

        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Favor informar Municipio.")]
        [Display(Name = "Município")]
        public string Municipio { get; set; }

        [Required(ErrorMessage = "Favor informar Estado.")]
        [StringLength(2, ErrorMessage = "Máximo 2 Caracteres")]
        [Display(Name = "Estado")]
        public string UF { get; set; }

        [Display(Name = "Foto")]
        public string Foto { get; set; }
    }
}