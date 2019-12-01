using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial_3.Models
{
    public class Visita
    {

        [Key]
        public int VisitaID { get; set; }
        public DateTime date_vis { get; set; }
        public TimeSpan bg_vis { get; set; }
        public TimeSpan end_vis { get; set; }
        public String vis_motive { get; set; }
        public virtual Persona persona { get; set; }
        public int PersonaID { get; set; }
        public int areaID { get; set; }
        public virtual Area area { get; set; }
    }
}