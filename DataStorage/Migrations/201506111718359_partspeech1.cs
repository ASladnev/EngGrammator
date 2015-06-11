namespace DataStorage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class partspeech1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PartSpeeches", "Name", c => c.String(maxLength: 12, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PartSpeeches", "Name", c => c.String(maxLength: 10, unicode: false));
        }
    }
}
