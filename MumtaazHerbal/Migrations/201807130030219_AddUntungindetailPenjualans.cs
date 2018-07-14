namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUntungindetailPenjualans : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DetailPenjualans", "Untung", c => c.Int(nullable: false));
            DropColumn("dbo.DetailPembelians", "Untung");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DetailPembelians", "Untung", c => c.Int(nullable: false));
            DropColumn("dbo.DetailPenjualans", "Untung");
        }
    }
}
