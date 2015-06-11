namespace DataStorage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lemma1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lemmata", "Description", c => c.String(maxLength: 80, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lemmata", "Description");
        }
    }
}
