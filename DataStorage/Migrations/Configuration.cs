using System.Collections.Generic;

namespace DataStorage.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataStorage.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataStorage.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            context.PartSpeeche.AddOrUpdate (
              new PartSpeech { PartSpeechId = "verb", Name = "varb", Description = "action or state" },
              new PartSpeech { PartSpeechId = "noun", Name = "name", Description = "thing or person" },
              new PartSpeech { PartSpeechId = "adj", Name = "adjective", Description = "describes a noun" },
              new PartSpeech { PartSpeechId = "adv", Name = "adverb", Description = "describes a verb, adjective or adverb" },
              new PartSpeech { PartSpeechId = "pron", Name = "pronoun", Description = "replaces a noun" },
              new PartSpeech { PartSpeechId = "prep", Name = "name", Description = "links a noun to another word" },
              new PartSpeech { PartSpeechId = "conj", Name = "conjunction", Description = "joins clauses or sentences or words" },
              new PartSpeech { PartSpeechId = "inter", Name = "interjection", Description = "short exclamation, sometimes inserted into a sentence" }
            );

            context.Lemma.AddOrUpdate (new Lemma { LemmaId = "work" },
              new Lemma { LemmaId = "run", PartSpeeches = new List<PartSpeech> {context.PartSpeeche.FirstOrDefault(p => p.PartSpeechId == "verb")}},
              new Lemma { LemmaId = "clean" }
            );


        }
    }
}
