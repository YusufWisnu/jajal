namespace MumtaazHerbal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDataTypeOfSatuanInItemsTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Satuan", c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Satuan", c => c.Int(nullable: false));
        }
    }
}
