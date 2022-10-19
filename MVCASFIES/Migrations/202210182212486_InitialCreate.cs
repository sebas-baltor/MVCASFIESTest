namespace MVCASFIES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        ApellidoMaterno = c.String(),
                        ApellidoPaterno = c.String(),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Correo = c.String(),
                        Telefono = c.String(),
                        Ocupacion = c.String(),
                        EstadoCivilId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EstadoCivils", t => t.EstadoCivilId, cascadeDelete: true)
                .Index(t => t.EstadoCivilId);
            
            CreateTable(
                "dbo.EstadoCivils",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PDFEstiloVidaDatoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SumaAseguradaPesos = c.Double(nullable: false),
                        SumaAseguradaUDIS = c.Double(nullable: false),
                        MultiploSalarioAnual = c.Int(nullable: false),
                        ClienteId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PDFEstiloVidaDatoes", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Clientes", "EstadoCivilId", "dbo.EstadoCivils");
            DropIndex("dbo.PDFEstiloVidaDatoes", new[] { "ClienteId" });
            DropIndex("dbo.Clientes", new[] { "EstadoCivilId" });
            DropTable("dbo.PDFEstiloVidaDatoes");
            DropTable("dbo.EstadoCivils");
            DropTable("dbo.Clientes");
        }
    }
}
