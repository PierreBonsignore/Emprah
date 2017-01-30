using BO.Equipements.Armes.Propriétés;
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

        public CategoriesArmes Categorie { get; set; }

        public int Portee { get; set; }
        public Cadence Cadence { get; set; }
        public Degats Degats { get; set; }
        public int Penetration { get; set; }
        public int Autonomie { get; set; }
        public Rech Rechargement { get; set; }
        public List<AttributArme> Attributs { get; set; }

        public Arme()
        {
            this.Attributs = new List<AttributArme>();
        }

        public Arme(string nom, TypesArmes type, CategoriesArmes categorie, int portee,
            Cadence cadence,Degats deg, int pen, int at, int rechValue, TypeRech typeRech)
        {
            this.Nom = nom;
            this.Type = type;
            this.Categorie = categorie;
            this.Portee = portee;
            this.Cadence = cadence;
            this.Degats = deg;
            this.Penetration = pen;
            this.Autonomie = at;
            this.Rechargement = new Rech(rechValue, typeRech);              
            this.Attributs = new List<AttributArme>();        
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append("\nType: " + this.Type + "\nCatégorie: " + this.Categorie + "\nPortée: " + this.Portee + "\nCadence: " + this.Cadence + "\nDégats: " + this.Degats + "\nPen: " + this.Penetration + "\nAT: " + this.Autonomie + "\nRech: " + this.Rechargement + "\nSpecial: " + this.Attributs);
            return s.ToString();
        }
    }
}
