using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialII.Models
{
    public class Area
    {
        [Key]
        public int AreaID { get; set; }
        public String n_area { get; set; }
        public bool state { get; set; }
    }
}