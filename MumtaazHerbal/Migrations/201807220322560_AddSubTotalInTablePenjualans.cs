namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSubTotalInTablePenjualans : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Penjualans", "SubTotal", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Penjualans", "SubTotal");
        }
    }
}
