namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPenjualanTableAndDoSomeChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Penjualans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NoTransaksi = c.String(maxLength: 255, unicode: false),
                        Tanggal = c.DateTime(nullable: false),
                        ItemId = c.Int(nullable: false),
                        PelangganId = c.Int(nullable: false),
                        JumlahBarang = c.Int(nullable: false),
                        TotalHarga = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Pelanggans", t => t.PelangganId, cascadeDelete: true)
                .Index(t => t.NoTransaksi, unique: true)
                .Index(t => t.ItemId)
                .Index(t => t.PelangganId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Penjualans", "PelangganId", "dbo.Pelanggans");
            DropForeignKey("dbo.Penjualans", "ItemId", "dbo.Items");
            DropIndex("dbo.Penjualans", new[] { "PelangganId" });
            DropIndex("dbo.Penjualans", new[] { "ItemId" });
            DropIndex("dbo.Penjualans", new[] { "NoTransaksi" });
            DropTable("dbo.Penjualans");
        }
    }
}
