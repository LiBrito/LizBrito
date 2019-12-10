using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final_Pres.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }
        [Display(Name = "Nombres")]
        public String NombreCliente { get; set; }
        [Display(Name = "Apellidos")]
        public String ApellidoCliente { get; set; }

        public String Identificacion { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public String Direccion { get; set; }
        [Display(Name = "Telefono Residencial")]
        public String TelefonoResidencial { get; set; }
        [Display(Name = "Telefono Celular")]
        public String TelefonoCelular { get; set; }

        public Decimal Salario { get; set; }
        [Display(Name = "Gastos Fijos")]
        public decimal GastosFijos { get; set; }
        [Display(Name = "Numero de Dependientes")]
        public int Dependientes { get; set; }
        public virtual ICollection<Prestamo> Prestamo { get; set; }
        




    }
}