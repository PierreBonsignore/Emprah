using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charac_Generator_DH2.Equipements
{
    abstract class Equipement
    {
        #region VARIABLES
        private string nom;
        private string poids;
        private string disponibilité;

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
        public string Poids
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
        public string Disponibilité
        {
            get
            {
                return disponibilité;
            }

            set
            {
                disponibilité = value;
            }
        }

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
    }
}
