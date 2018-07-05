namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPendingInTableDetailPenjualan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DetailPenjualans", "IsPending", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DetailPenjualans", "IsPending");
        }
    }
}
