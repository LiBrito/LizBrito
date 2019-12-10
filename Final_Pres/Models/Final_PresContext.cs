using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Final_Pres.Models
{
    public class Final_PresContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Final_PresContext() : base("name=Final_PresContext")
        {
        }

        public System.Data.Entity.DbSet<Final_Pres.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<Final_Pres.Models.Prestamo> Prestamoes { get; set; }

        public System.Data.Entity.DbSet<Final_Pres.Models.Usuario> Usuarios { get; set; }
    }
}
