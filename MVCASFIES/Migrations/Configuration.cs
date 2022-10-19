namespace MVCASFIES.Migrations
{
    using MVCASFIES.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCASFIES.Context.MVCASFIESContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MVCASFIES.Context.MVCASFIESContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            List<EstadoCivil> estados = new List<EstadoCivil> {
                new EstadoCivil{Id=1,Estado="Soltero/Soltera"},
                new EstadoCivil{Id=2,Estado="Casado/Casada"},
                new EstadoCivil{Id=3,Estado="Unión Libre"},
                new EstadoCivil{Id=4,Estado="Concubinado"},
                new EstadoCivil{Id=5,Estado="Viudo/Viuda"},
            };
            estados.ForEach(e => context.EstadoCiviles.AddOrUpdate(t => t.Id, e));

        }
    }
}
