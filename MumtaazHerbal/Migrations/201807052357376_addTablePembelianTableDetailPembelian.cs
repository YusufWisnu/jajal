namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTablePembelianTableDetailPembelian : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetailPembelians",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JumlahBarang = c.Int(nullable: false),
                        HargaBarang = c.Int(nullable: false),
                        PembelianId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Pembelians", t => t.PembelianId, cascadeDelete: true)
                .Index(t => t.PembelianId)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.Pembelians",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NoTransaksi = c.String(),
                        Tanggal = c.DateTime(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        TotalHarga = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.SupplierId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pembelians", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.DetailPembelians", "PembelianId", "dbo.Pembelians");
            DropForeignKey("dbo.DetailPembelians", "ItemId", "dbo.Items");
            DropIndex("dbo.Pembelians", new[] { "SupplierId" });
            DropIndex("dbo.DetailPembelians", new[] { "ItemId" });
            DropIndex("dbo.DetailPembelians", new[] { "PembelianId" });
            DropTable("dbo.Pembelians");
            DropTable("dbo.DetailPembelians");
        }
    }
}
