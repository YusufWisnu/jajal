namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteJumlahBarangFromTablePenjualan : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Penjualans", "JumlahBarang");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Penjualans", "JumlahBarang", c => c.Int(nullable: false));
        }
    }
}
