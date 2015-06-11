namespace DataStorage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class partspeech2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PartSpeeches", "Description", c => c.String(maxLength: 60, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PartSpeeches", "Description", c => c.String(maxLength: 40, unicode: false));
        }
    }
}
