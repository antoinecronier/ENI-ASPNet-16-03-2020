using System.Collections.Generic;

namespace BO
{
    public class Samourai : BaseDbEntity
    {
        public int Force { get; set; }
        public string Nom { get; set; }
        public virtual Arme Arme { get; set; }
        public List<ArtMartial> ArtMartials { get; set; } = new List<ArtMartial>();
    }
}
