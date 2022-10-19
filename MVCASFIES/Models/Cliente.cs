using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCASFIES.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ApellidoMaterno { get; set; }
        public string ApellidoPaterno { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Ocupacion { get; set; }
        public int EstadoCivilId { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
    }
}