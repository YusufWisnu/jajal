namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addColumnSisaFromTablePiutang : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DetailPiutangs", "Sisa", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DetailPiutangs", "Sisa");
        }
    }
}
