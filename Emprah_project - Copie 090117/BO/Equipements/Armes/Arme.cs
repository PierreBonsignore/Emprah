using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
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

        public Arme()
        { }

        public Arme(TypesArmes type=TypesArmes.Base, string nom="", int portee=0, Cadence cadence= null, Degats deg = null, int pen=0, int at=0, Rech rech=null,ArmeSpecial spec = null, Disponibilité dispo = Disponibilité.Commun, int poids=0, string refPage="0") : base (nom, poids, dispo, refPage)
        {
            this.Nom = nom;
            this.Type = type;
            this.Portée = portee;
            this.Cadence = cadence;
            this.Degats = deg;
            this.Penetration = pen;
            this.Autonomie = at;
            this.Rechargement = rech;
            this.Special = spec;
            this.Disponibilité = dispo;
            this.Poids = poids;
            this.RefPage = refPage;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append("\nType: " + this.Type + "\nPortée: " + this.Portée + "\nCadence: " + this.Cadence + "\nDégats: " + this.Degats + "\nPen: " + this.Penetration + "\nAT: " + this.Autonomie + "\nRech: " + this.Rechargement + "\nSpecial: " + this.Special);
            return s.ToString();
        }
    }
}
