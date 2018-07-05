namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeColumnIsPendingandKeteranganIntoTablePenjualan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Penjualans", "IsPending", c => c.Boolean(nullable: false));
            AddColumn("dbo.Penjualans", "Keterangan", c => c.String());
            DropColumn("dbo.DetailPenjualans", "IsPending");
            DropColumn("dbo.DetailPenjualans", "Keterangan");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DetailPenjualans", "Keterangan", c => c.String());
            AddColumn("dbo.DetailPenjualans", "IsPending", c => c.Boolean(nullable: false));
            DropColumn("dbo.Penjualans", "Keterangan");
            DropColumn("dbo.Penjualans", "IsPending");
        }
    }
}
