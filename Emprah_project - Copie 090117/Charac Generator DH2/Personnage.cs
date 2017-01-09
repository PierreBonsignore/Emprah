using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Charac_Generator_DH2.Mondes_Natal;

namespace Charac_Generator_DH2
{
    class Personnage
    {
        #region Variables
        private string _nom;
        private Monde_Natal mondeNatal;

        private int pointsDeVie;
        private int pointsDeDestin;        

        #region caracs
        private List<Caractéristique> caractéristiques;

        private Caractéristique _CC;
        private Caractéristique _CT;
        private Caractéristique _FOR;
        private Caractéristique _END;
        private Caractéristique _AGI;
        private Caractéristique _INT;
        private Caractéristique _PER;
        private Caractéristique _FM;
        private Caractéristique _SOC;
        private Caractéristique _INF;
        #endregion

        #endregion

        #region Propriétés

        public String Nom
        {
            set
            {

                this._nom = value;
            }
            get { return this._nom; }
        }
        public Monde_Natal MondeNatal
        {
            get
            {
                return mondeNatal;
            }

            set
            {
                mondeNatal = value;
            }
        }

        public int PointsDeVie
        {
            get
            {
                return pointsDeVie;
            }

            set
            {
                pointsDeVie = value;
            }
        }
        public int PointsDeDestin
        {
            get
            {
                return pointsDeDestin;
            }

            set
            {
                pointsDeDestin = value;
            }
        }



        #region Caractéristiques
        public Caractéristique CC
        {
            get
            {
                return _CC;
            }

            set
            {
                _CC = value;
            }
        }

        public Caractéristique CT
        {
            get
            {
                return _CT;
            }

            set
            {
                _CT = value;
            }
        }

        public Caractéristique FOR
        {
            get
            {
                return _FOR;
            }

            set
            {
                _FOR = value;
            }
        }

        public Caractéristique END
        {
            get
            {
                return _END;
            }

            set
            {
                _END = value;
            }
        }

        public Caractéristique AGI
        {
            get
            {
                return _AGI;
            }

            set
            {
                _AGI = value;
            }
        }

        public Caractéristique INT
        {
            get
            {
                return _INT;
            }

            set
            {
                _INT = value;
            }
        }

        public Caractéristique PER
        {
            get
            {
                return _PER;
            }

            set
            {
                _PER = value;
            }
        }

        public Caractéristique FM
        {
            get
            {
                return _FM;
            }

            set
            {
                _FM = value;
            }
        }

        public Caractéristique SOC
        {
            get
            {
                return _SOC;
            }

            set
            {
                _SOC = value;
            }
        }

        public Caractéristique INF
        {
            get
            {
                return _INF;
            }

            set
            {
                _INF = value;
            }
        }

        public List<Caractéristique> Caractéristiques
        {
            get
            {
                return caractéristiques;
            }

            set
            {
                caractéristiques = value;
            }
        }


        #endregion

        #endregion

        #region Constructeur
        public Personnage(string nom)
        {
            this.Nom = nom;
            this.Caractéristiques = GénérerListeCarac();
        }
        #endregion

        #region Methodes
        public List<Caractéristique> GénérerListeCarac()
        {
            this.CC = new Caractéristique("Capacité de Combat","CC");
            this.CT = new Caractéristique("Capacité de Tir","CT");
            this.FOR = new Caractéristique("Force","FOR");
            this.END = new Caractéristique("Endurance","END");
            this.AGI = new Caractéristique("Agilité","AGI");
            this.INT = new Caractéristique("Intelligence","INT");
            this.PER = new Caractéristique("Perception", "PER");
            this.FM = new Caractéristique("Force Mentale", "FM");
            this.SOC = new Caractéristique("Sociabilité", "SOC");
            this.INF = new Caractéristique("Influence", "INF");
            List<Caractéristique> listeCarac = new List<Caractéristique>();
            listeCarac.Add(this.CC);
            listeCarac.Add(this.CT);
            listeCarac.Add(this.FOR);
            listeCarac.Add(this.END);
            listeCarac.Add(this.AGI);
            listeCarac.Add(this.INT);
            listeCarac.Add(this.PER);
            listeCarac.Add(this.FM);
            listeCarac.Add(this.SOC);
            listeCarac.Add(this.INF);
            return listeCarac;
        }
        public string FichePerso()
        {
            
            StringBuilder tableau = new StringBuilder();
            string blank = "";
            foreach (var item in Caractéristiques)
            {
                tableau.Append("|"+ item.DiminutifCaractéristique.PadLeft(3) +" ");
            }
            tableau.Append("|\n");
            foreach (var item in Caractéristiques)
            {
                tableau.Append("|"+ item.ValeurDeCaractéristique.ToString().PadLeft(3)+" ");
            }
            tableau.Append("|");
            string s = string.Concat
            (
            "\nNom du personnage: " + this.Nom
            + "\n\nMonde Natal: " + this.MondeNatal.TypeMonde
            + "\n\nPoints de Vie: " + this.PointsDeVie
            + "\n\nPoints de Destin: " + this.PointsDeDestin
            + "\n\n" + tableau
            );

            return s;
        }
        #endregion







    }
}
