namespace DataStorage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class partspeech : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PartSpeeches",
                c => new
                    {
                        PartSpeechId = c.String(nullable: false, maxLength: 5, unicode: false),
                        Name = c.String(maxLength: 10, unicode: false),
                        Description = c.String(maxLength: 40, unicode: false),
                    })
                .PrimaryKey(t => t.PartSpeechId);
            
            CreateTable(
                "dbo.PartSpeechLemmas",
                c => new
                    {
                        PartSpeech_PartSpeechId = c.String(nullable: false, maxLength: 5, unicode: false),
                        Lemma_LemmaId = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => new { t.PartSpeech_PartSpeechId, t.Lemma_LemmaId })
                .ForeignKey("dbo.PartSpeeches", t => t.PartSpeech_PartSpeechId, cascadeDelete: true)
                .ForeignKey("dbo.Lemmata", t => t.Lemma_LemmaId, cascadeDelete: true)
                .Index(t => t.PartSpeech_PartSpeechId)
                .Index(t => t.Lemma_LemmaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PartSpeechLemmas", "Lemma_LemmaId", "dbo.Lemmata");
            DropForeignKey("dbo.PartSpeechLemmas", "PartSpeech_PartSpeechId", "dbo.PartSpeeches");
            DropIndex("dbo.PartSpeechLemmas", new[] { "Lemma_LemmaId" });
            DropIndex("dbo.PartSpeechLemmas", new[] { "PartSpeech_PartSpeechId" });
            DropTable("dbo.PartSpeechLemmas");
            DropTable("dbo.PartSpeeches");
        }
    }
}
