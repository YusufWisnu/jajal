namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingAnotherRelatedTablepls : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetailPiutangs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PiutangId = c.Int(nullable: false),
                        PenjualanId = c.Int(nullable: false),
                        JumlahBayar = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Penjualans", t => t.PenjualanId)
                .ForeignKey("dbo.Piutangs", t => t.PiutangId)
                .Index(t => t.PiutangId)
                .Index(t => t.PenjualanId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetailPiutangs", "PiutangId", "dbo.Piutangs");
            DropForeignKey("dbo.DetailPiutangs", "PenjualanId", "dbo.Penjualans");
            DropIndex("dbo.DetailPiutangs", new[] { "PenjualanId" });
            DropIndex("dbo.DetailPiutangs", new[] { "PiutangId" });
            DropTable("dbo.DetailPiutangs");
        }
    }
}
