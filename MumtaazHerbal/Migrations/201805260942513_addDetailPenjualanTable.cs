namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDetailPenjualanTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetailPenjualans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JumlahBarang = c.Int(nullable: false),
                        PenjualanId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId)
                .ForeignKey("dbo.Penjualans", t => t.PenjualanId)
                .Index(t => t.PenjualanId)
                .Index(t => t.ItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetailPenjualans", "PenjualanId", "dbo.Penjualans");
            DropForeignKey("dbo.DetailPenjualans", "ItemId", "dbo.Items");
            DropIndex("dbo.DetailPenjualans", new[] { "ItemId" });
            DropIndex("dbo.DetailPenjualans", new[] { "PenjualanId" });
            DropTable("dbo.DetailPenjualans");
        }
    }
}
