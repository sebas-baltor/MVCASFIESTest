using MVCASFIES.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVCASFIES.Context
{
    public partial class MVCASFIESContext : DbContext
    {
        public MVCASFIESContext()
            : base("name=MVCASFIESContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCiviles { get; set; }
        public virtual DbSet<PDFEstiloVidaDato> PDFEstiloVidaDatos { get; set; }
    }
}
