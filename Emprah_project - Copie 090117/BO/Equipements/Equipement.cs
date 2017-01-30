using BO.Equipements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    public abstract class Equipement
    {
        #region VARIABLES
        private string nom;
        private int poids;
        private string referencePage;
        private Source source;
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
                return referencePage;
            }

            set
            {
                referencePage = value;
            }
        }

        public Source Source
        {
            get { return source; }
            set { source = value; }
        }

        #endregion

        public Equipement()
        {

        }

        public Equipement(string nom, Disponibilité dispo=Disponibilité.Courant, int pds=0, string refPage="", Source src=Source.Personalisé)
        {
            this.Nom = nom;
            this.Poids = poids;
            this.Disponibilité = dispo;
            this.poids = pds;
            this.RefPage = refPage;
            this.Source = src;
        }

        public override string ToString()
        {
            return this.Nom;
        }
    }
}
