namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NamaItem = c.String(nullable: false, maxLength: 255, unicode: false),
                        KodeItem = c.String(nullable: false, maxLength: 50, unicode: false),
                        Stok = c.Int(nullable: false),
                        Satuan = c.Int(nullable: false),
                        HargaGrosir = c.Int(nullable: false),
                        HargaEceran = c.Int(nullable: false),
                        HargaJual = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KodeSupplier = c.String(nullable: false, maxLength: 20, unicode: false),
                        NamaSupplier = c.String(nullable: false, maxLength: 255, unicode: false),
                        Alamat = c.String(maxLength: 255, unicode: false),
                        NoHP = c.String(maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.KodeSupplier);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "SupplierId", "dbo.Suppliers");
            DropIndex("dbo.Suppliers", new[] { "KodeSupplier" });
            DropIndex("dbo.Items", new[] { "SupplierId" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Items");
        }
    }
}
