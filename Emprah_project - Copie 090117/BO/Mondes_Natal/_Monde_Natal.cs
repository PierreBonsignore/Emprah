using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Monde_Natal
    {
        
        

        #region Var
        private TypeMonde typeMonde;
        private string nomMonde;
        private string infoMond;        
       
        private int ptsDestin;
        private int empBen;
        private string aptitude;
        private string hwBonus;

        private int refPage;

        private string infoModifCarac;        

        

        int ptsBlessuresBase;
        #endregion
        #region Props
        public TypeMonde TypeMonde
        {
            get
            {
                return typeMonde;
            }

            set
            {
                typeMonde = value;
            }
        }
        public string InfoMond
        {
            get
            {
                return infoMond;
            }
            set
            {
                this.infoMond = value;
            }
        }
        public string DesignationMonde
        {
            get
            {
                return nomMonde;
            }

            set
            {
                nomMonde = value;
            }
        }

        public int PtsDestinBase
        {
            get
            {
                return ptsDestin;
            }

            set
            {
                ptsDestin = value;
            }
        }       
       

        public int PtsBlessuresBase
        {
            get
            {
                return ptsBlessuresBase;
            }

            set
            {
                ptsBlessuresBase = value;
            }
        }

        public int EmpereurBenediction
        {
            get
            {
                return empBen;
            }

            set
            {
                empBen = value;
            }
        }

        public string Aptitude
        {
            get
            {
                return aptitude;
            }

            set
            {
                aptitude = value;
            }
        }

        public string Bonus_MondeNatal
        {
            get
            {
                return hwBonus;
            }

            set
            {
                hwBonus = value;
            }
        }

        public int RefPage
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

        public string InfoModifCarac
        {
            get
            {
                return infoModifCarac;
            }

            set
            {
                infoModifCarac = value;
            }
        }

        #endregion

        public Monde_Natal()
        {            
            this.InfoMond = "Description monde natal";
        }

        #region Methodes
        public override string ToString()
        {
            string s = "\n" + this.InfoMond + "\n"
                + "\nMODIFICATEURS DE CARACTERISTIQUES: " + this.InfoModifCarac
                + "\nDESTIN : " + this.PtsDestinBase + "(Bénédiction de l'Empereur sur " + this.EmpereurBenediction + "+ )"
                + "\nBONUS MONDE NATAL: " + this.Bonus_MondeNatal
                + "\nAPTITUDE: " + this.Aptitude
                + "\nPOINTS DE VIE: " + this.PtsBlessuresBase + " + 1d5."
                + "\nRef Page: " + this.RefPage;
            return s;
        }

        #endregion

    }
}
