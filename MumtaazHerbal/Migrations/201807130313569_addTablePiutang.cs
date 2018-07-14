namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTablePiutang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Piutangs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NoTransaksi = c.String(maxLength: 255, unicode: false),
                        TanggalJT = c.DateTime(nullable: false),
                        Sisa = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                        pelangganId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pelanggans", t => t.pelangganId, cascadeDelete: true)
                .Index(t => t.NoTransaksi, unique: true)
                .Index(t => t.pelangganId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Piutangs", "pelangganId", "dbo.Pelanggans");
            DropIndex("dbo.Piutangs", new[] { "pelangganId" });
            DropIndex("dbo.Piutangs", new[] { "NoTransaksi" });
            DropTable("dbo.Piutangs");
        }
    }
}
