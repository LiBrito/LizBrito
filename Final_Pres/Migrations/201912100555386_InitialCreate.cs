namespace Final_Pres.Migrations
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
                        ClienteID = c.Int(nullable: false, identity: true),
                        NombreCliente = c.String(),
                        ApellidoCliente = c.String(),
                        Identificacion = c.String(),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Edad = c.Int(nullable: false),
                        Direccion = c.String(),
                        TelefonoResidencial = c.String(),
                        TelefonoCelular = c.String(),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GastosFijos = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Dependientes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.Prestamoes",
                c => new
                    {
                        PresID = c.Int(nullable: false, identity: true),
                        Desembolso = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Avances = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Activo = c.Boolean(nullable: false),
                        PaysPerYear = c.Int(nullable: false),
                        Start_Date = c.DateTime(nullable: false),
                        PagosAdicionales = c.Double(nullable: false),
                        NumeroDePagos_p = c.Int(nullable: false),
                        NumeroDePagos_r = c.Int(nullable: false),
                        InteresRate = c.Double(nullable: false),
                        PagosAnticipados = c.Int(nullable: false),
                        Years = c.Int(nullable: false),
                        Agente_UsuarioID = c.Int(),
                        Cliente_ClienteID = c.Int(),
                        ClienteID_ClienteID = c.Int(),
                        UsuarioID_UsuarioID = c.Int(),
                    })
                .PrimaryKey(t => t.PresID)
                .ForeignKey("dbo.Usuarios", t => t.Agente_UsuarioID)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ClienteID)
                .ForeignKey("dbo.Clientes", t => t.ClienteID_ClienteID)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioID_UsuarioID)
                .Index(t => t.Agente_UsuarioID)
                .Index(t => t.Cliente_ClienteID)
                .Index(t => t.ClienteID_ClienteID)
                .Index(t => t.UsuarioID_UsuarioID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Correo = c.String(),
                        Clave = c.String(),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prestamoes", "UsuarioID_UsuarioID", "dbo.Usuarios");
            DropForeignKey("dbo.Prestamoes", "ClienteID_ClienteID", "dbo.Clientes");
            DropForeignKey("dbo.Prestamoes", "Cliente_ClienteID", "dbo.Clientes");
            DropForeignKey("dbo.Prestamoes", "Agente_UsuarioID", "dbo.Usuarios");
            DropIndex("dbo.Prestamoes", new[] { "UsuarioID_UsuarioID" });
            DropIndex("dbo.Prestamoes", new[] { "ClienteID_ClienteID" });
            DropIndex("dbo.Prestamoes", new[] { "Cliente_ClienteID" });
            DropIndex("dbo.Prestamoes", new[] { "Agente_UsuarioID" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Prestamoes");
            DropTable("dbo.Clientes");
        }
    }
}
