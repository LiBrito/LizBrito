using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ParcialII.Models
{
    public class ParcialIIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ParcialIIContext() : base("name=ParcialIIContext")
        {
        }

        public System.Data.Entity.DbSet<ParcialII.Models.Persona> Personas { get; set; }
        public System.Data.Entity.DbSet<ParcialII.Models.Area> Area { get; set; }
        public System.Data.Entity.DbSet<ParcialII.Models.Visitas> Visitas { get; set; }
    }
}
