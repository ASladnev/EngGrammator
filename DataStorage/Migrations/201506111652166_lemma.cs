namespace DataStorage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lemma : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lemmata",
                c => new
                    {
                        LemmaId = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.LemmaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Lemmata");
        }


    }
}
