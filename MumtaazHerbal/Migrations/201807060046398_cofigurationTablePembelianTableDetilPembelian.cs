namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cofigurationTablePembelianTableDetilPembelian : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DetailPembelians", "ItemId", "dbo.Items");
            DropForeignKey("dbo.DetailPembelians", "PembelianId", "dbo.Pembelians");
            AlterColumn("dbo.Pembelians", "NoTransaksi", c => c.String(maxLength: 255, unicode: false));
            CreateIndex("dbo.Pembelians", "NoTransaksi", unique: true);
            AddForeignKey("dbo.DetailPembelians", "ItemId", "dbo.Items", "Id");
            AddForeignKey("dbo.DetailPembelians", "PembelianId", "dbo.Pembelians", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetailPembelians", "PembelianId", "dbo.Pembelians");
            DropForeignKey("dbo.DetailPembelians", "ItemId", "dbo.Items");
            DropIndex("dbo.Pembelians", new[] { "NoTransaksi" });
            AlterColumn("dbo.Pembelians", "NoTransaksi", c => c.String());
            AddForeignKey("dbo.DetailPembelians", "PembelianId", "dbo.Pembelians", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DetailPembelians", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
        }
    }
}
