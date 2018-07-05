namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHargaBarangFromTableDetailPenjualan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DetailPenjualans", "HargaBarang", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DetailPenjualans", "HargaBarang");
        }
    }
}
