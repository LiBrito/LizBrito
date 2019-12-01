namespace Parcial_3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        AreaID = c.Int(nullable: false, identity: true),
                        n_area = c.String(),
                        state = c.Boolean(nullable: false),
                        visitaNum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AreaID);
            
            CreateTable(
                "dbo.Visitas",
                c => new
                    {
                        VisitaID = c.Int(nullable: false, identity: true),
                        date_vis = c.DateTime(nullable: false),
                        bg_vis = c.Time(nullable: false, precision: 7),
                        end_vis = c.Time(nullable: false, precision: 7),
                        vis_motive = c.String(),
                        PersonaID = c.Int(nullable: false),
                        areaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VisitaID)
                .ForeignKey("dbo.Areas", t => t.areaID, cascadeDelete: true)
                .ForeignKey("dbo.Personas", t => t.PersonaID, cascadeDelete: true)
                .Index(t => t.PersonaID)
                .Index(t => t.areaID);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        PersonaID = c.Int(nullable: false, identity: true),
                        nombre_p = c.String(),
                        lname_p = c.String(),
                        tel_p = c.Int(nullable: false),
                        adress_p = c.String(),
                        email_p = c.String(),
                    })
                .PrimaryKey(t => t.PersonaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visitas", "PersonaID", "dbo.Personas");
            DropForeignKey("dbo.Visitas", "areaID", "dbo.Areas");
            DropIndex("dbo.Visitas", new[] { "areaID" });
            DropIndex("dbo.Visitas", new[] { "PersonaID" });
            DropTable("dbo.Personas");
            DropTable("dbo.Visitas");
            DropTable("dbo.Areas");
        }
    }
}
