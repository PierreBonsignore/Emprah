using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public abstract class Equipement
    {
        #region VARIABLES
        private string nom;
        private int poids;
        private string refPage;
        #endregion

        #region PROPS
        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }
        public int Poids
        {
            get
            {
                return poids;
            }

            set
            {
                poids = value;
            }
        }
        public Disponibilité Disponibilité
        {get; set;}
        public string RefPage
        {
            get
            {
                return refPage;
            }

            set
            {
                refPage = value;
            }
        }
        #endregion
     
        public Equipement()
        {

        }

        public Equipement(string nom=null, int poids = 0,Disponibilité dispo=Disponibilité.Commun, string refPage = "0")
        {
            this.Nom = nom;
            this.Poids = poids;
            this.Disponibilité = dispo;
            this.RefPage = refPage;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(this.Nom.ToUpper() + "\nPoids: " + this.Poids + " kg\nPage: " + this.RefPage + "\nDisponibilité: " + this.Disponibilité);
            return s.ToString();
        }
    }
}
