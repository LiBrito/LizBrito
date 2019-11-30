using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialII.Models
{
    public class Visitas
    {
        [Key]
        public int VisitaID { get; set; }
        public DateTime date_vis { get; set; }
        public TimeSpan bg_vis {get; set; }
        public TimeSpan end_vis { get; set; }
        public String vis_motive { get; set; }
        public virtual Persona persona { get; set; }
        public Persona IdPersona { get; set; }

}
}