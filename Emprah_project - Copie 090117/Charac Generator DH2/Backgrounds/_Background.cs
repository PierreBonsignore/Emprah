using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charac_Generator_DH2.Backgrounds
{
    abstract class _Background
    {
        Saisies saisies = new Saisies();

        #region variables
        private string nomBg;
        private string descriptionBg;
        private string refPage;

        private string competencesDeDepart;
        private string talentsDeDepart;
        private string equipementsDeDepart;

        private string backgroundAptitude;
        private string backgroundBonus;


        #endregion

        #region props
        public string NomBg
        {
            get
            {
                return nomBg;
            }

            set
            {
                nomBg = value;
            }
        }

        public string DescriptionBg
        {
            get
            {
                return descriptionBg;
            }

            set
            {
                descriptionBg = value;
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

        public string CompetencesDeDepart
        {
            get
            {
                return competencesDeDepart;
            }

            set
            {
                competencesDeDepart = value;
            }
        }

        public string TalentsDeDepart
        {
            get
            {
                return talentsDeDepart;
            }

            set
            {
                talentsDeDepart = value;
            }
        }

        public string EquipementsDeDepart
        {
            get
            {
                return equipementsDeDepart;
            }

            set
            {
                equipementsDeDepart = value;
            }
        }

        public string BackgroundAptitude
        {
            get
            {
                return backgroundAptitude;
            }

            set
            {
                backgroundAptitude = value;
            }
        }

        public string BackgroundBonus
        {
            get
            {
                return backgroundBonus;
            }

            set
            {
                backgroundBonus = value;
            }
        }
        #endregion

        #region methodes
        public override string ToString()
        {
            string s= "";
            return s;
        }
        #endregion
    }
}
