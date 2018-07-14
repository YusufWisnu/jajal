namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUntunginTableDetailPembelians : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DetailPembelians", "Untung", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DetailPembelians", "Untung");
        }
    }
}
