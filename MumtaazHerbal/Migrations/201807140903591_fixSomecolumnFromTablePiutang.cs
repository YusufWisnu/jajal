namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixSomecolumnFromTablePiutang : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Piutangs", "Tanggal", c => c.DateTime(nullable: false));
            DropColumn("dbo.Piutangs", "TanggalJT");
            DropColumn("dbo.Piutangs", "Sisa");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Piutangs", "Sisa", c => c.Int(nullable: false));
            AddColumn("dbo.Piutangs", "TanggalJT", c => c.DateTime(nullable: false));
            DropColumn("dbo.Piutangs", "Tanggal");
        }
    }
}
