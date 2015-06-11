using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage
{
  public class PartSpeech
  {
    public PartSpeech ()
    {
      Lemmas = new HashSet<Lemma> ();
    }

    public string PartSpeechId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual ICollection<Lemma> Lemmas { get; set; }
  }


  public class PartSpeechMeta : EntityTypeConfiguration<PartSpeech>
  {
    public PartSpeechMeta ()
    {
      Property (p => p.PartSpeechId).HasColumnType ("varchar").HasMaxLength (5);
      Property (p => p.Name).HasColumnType ("varchar").HasMaxLength (12);
      Property (p => p.Description).HasColumnType ("varchar").HasMaxLength (60);
    }
  }
}
