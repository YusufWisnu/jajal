namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddJumlahItemIntoTablePenjualanAndPembelian : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Penjualans", "JumlahItem", c => c.Int(nullable: false));
            AddColumn("dbo.Pembelians", "JumlahItem", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pembelians", "JumlahItem");
            DropColumn("dbo.Penjualans", "JumlahItem");
        }
    }
}
