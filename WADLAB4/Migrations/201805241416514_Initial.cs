namespace WADLAB4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                        Location = c.String(),
                        Category = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Materies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nume = c.String(),
                        TotalOre = c.Int(nullable: false),
                        Credite = c.Int(nullable: false),
                        Profesor = c.Long(nullable: false),
                        Spec = c.Int(nullable: false),
                        An = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Note",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Student = c.Long(nullable: false),
                        Materie = c.String(),
                        Calificativ = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        message = c.String(),
                        link = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Profesor",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CNP = c.Long(nullable: false),
                        Nume = c.String(),
                        Prenume = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Specs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nume = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CNP = c.Long(nullable: false),
                        Nume = c.String(),
                        Prenume = c.String(),
                        An = c.Int(nullable: false),
                        Semestru = c.Int(nullable: false),
                        Specializare = c.String(),
                        Credite = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.Specs");
            DropTable("dbo.Profesor");
            DropTable("dbo.News");
            DropTable("dbo.Note");
            DropTable("dbo.Materii");
            DropTable("dbo.Events");
        }
    }
}
