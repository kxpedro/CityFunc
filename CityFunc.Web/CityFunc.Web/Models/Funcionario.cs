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
        public int Id { get; set; }

        [Required(ErrorMessage = "Favor informar Nome Completo.")]        
        public string Nome { get; set; }

        [Required(ErrorMessage = "Favor informar Telefone.")]
        [StringLength(20, ErrorMessage = "Máximo 20 Caracteres")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Favor informar CPF.")]
        [StringLength(11, ErrorMessage = "Máximo 11 Caracteres")]
        public string CPF { get; set; }
        
        [Required(ErrorMessage = "Favor informar CEP.")]
        [StringLength(8, ErrorMessage = "Máximo 7 Caracteres")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Favor informar Endereço.")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Favor informar Numero.")]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "Favor informar Municipio.")]
        public string Municipio { get; set; }

        [Required(ErrorMessage = "Favor informar Estado.")]
        [StringLength(2, ErrorMessage = "Máximo 2 Caracteres")]
        public string UF { get; set; }
        
        public string Foto { get; set; }
    }
}