using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Arme : Equipement
    {
        public TypesArmes Type { get; set; }
        public int Portée { get; set; }
        public Cadence Cadence { get; set; } 
        public Degats Degats { get; set; }
        public int Penetration { get; set; }
        public int Autonomie { get; set; }
        public Rech Rechargement { get; set; }
        public ArmeSpecial Special { get; set; }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append("\nType: "+this.Type+"\nPortée: "+this.Portée+"\nCadence: "+this.Cadence+"\nDégats: "+this.Degats+"\nPen: "+this.Penetration+"\nAT: "+this.Autonomie+"\nRech: "+this.Rechargement+"\nSpecial: "+this.Special);
            return base.ToString() + s.ToString();
        }
    }
}
