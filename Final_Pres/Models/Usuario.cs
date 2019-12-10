using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final_Pres.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        public String Nombre { get; set; }
        public String Correo { get; set; }
        public String Clave { get; set; }
        public Boolean Estado { get; set; }
        public virtual ICollection<Prestamo> Prestamo { get; set; }
    }
}