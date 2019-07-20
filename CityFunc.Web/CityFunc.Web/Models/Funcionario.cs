using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CityFunc.Web.Models
{    
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }        

        public string Telefone { get; set; }

        public string CPF { get; set; }

        public string CEP { get; set; }

        public string Endereco { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Municipio { get; set; }

        public string UF { get; set; }

        public string Foto { get; set; }
    }
}