using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;

namespace BO
{
    /// <summary>
    /// Détermine la cadence de tir d'une arme.
    /// Propriétés CoupParCoup, SemiAuto et Automatique.
    /// </summary>
    [Serializable]
    public class Cadence
    {
        // Cadence: C/S/A

        private int c;
        private int s;
        private int a;

        public int CoupParCoup
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }

        public int SemiAuto
        {
            get
            {
                return s;
            }

            set
            {
                s = value;
            }
        }

        public int Automatique
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        public Cadence(int cpc, int semiAuto, int auto)
        {
            this.CoupParCoup = cpc;
            this.SemiAuto = semiAuto;
            this.Automatique = auto;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", this.CoupParCoup,this.SemiAuto, this.Automatique);
        }
    }
}