using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCASFIES.Models
{
    public class PDFEstiloVidaDato
    {
        public int Id { get; set; }
        [Display(Name ="Suma asegurada en pesos")]
        public double SumaAseguradaPesos { get; set; }
        public double SumaAseguradaUDIS { get; set; }
        public int MultiploSalarioAnual { get; set; }
        public Guid ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}