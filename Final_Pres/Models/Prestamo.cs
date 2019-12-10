using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final_Pres.Models
{
    public class Prestamo
    {
        [Key]
        public int PresID { get; set; }

        public decimal Desembolso { get; set; }
        //public decimal Balance { get; set; }
        //[Display(Name = "Interes Acumulado")]
        //public decimal InteresAcumulado { get; set; }
        public decimal Avances { get; set; }
        public Boolean Activo { get; set; }
        [Display(Name = "Pagos por Año")]
        public int PaysPerYear { get; set; }
        [Display(Name = "Fecha de Inicio")]
        public DateTime Start_Date { get; set; }
        [Display(Name = "Pagos Adicionales")]
        public double PagosAdicionales { get; set; }
        //public double Cuota { get; set; }
        [Display(Name = "Numero de Pagos Programados")]
        public int NumeroDePagos_p { get; set; }
        [Display(Name = "Numero de Pagos Reales")]
        public int NumeroDePagos_r { get; set; }
        [Display(Name = "Tasa de Interés")]
        public decimal InteresRate { get; set; }
        [Display(Name = "Pagos Anticipados")]
        public int PagosAnticipados { get; set; }
        [Display(Name = "Timpo de Vigencia en Años")]
        public int Years { get; set; }
        [Display(Name = "Nombre del Agente")]
        public virtual Usuario UsuarioID { get; set; }
        public Usuario Usuario { get; set; }
        [Display(Name = "Nombre del Cliente")]
        public virtual Cliente ClienteID { get; set; }
        public Cliente Cliente { get; set; }
    }
}