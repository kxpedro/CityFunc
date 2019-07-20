using CityFunc.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CityFunc.Web.Entity.Context
{
    public class Context : DbContext
    {
        public Context() : base("Data Source=DESKTOP-V7P7F5I;Initial Catalog=CityFunc;Integrated Security=True")
        {

        }

        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Municipio> Municipio { get; set; }
    }
}