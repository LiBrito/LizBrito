using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialII.Models
{
    public class Persona
    {
        [Key]
        public int PersonaID { get; set; }
        public String nombre_p { get; set; }
        public String lname_p { get; set; }
        public int tel_p { get; set; }
        public String adress_p { get; set; }
        public String email_p { get; set; }

    }
}