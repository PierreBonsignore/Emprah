using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charac_Generator_DH2.Mondes_Natal
{
    class MondeRuche : Monde_Natal
    {
        public MondeRuche()
        {
            Dés jetDé = new Dés();
            this.InfoMond = "Monde à la population massive, composé de cité-ruches remplies de gangs.";
            this.DesignationMonde = "vient d'un Monde Ruche.";
            this.PtsBlessuresBase = 8;
            this.PtsDestinBase = 2;
            this.EmpereurBenediction = 6;
            this.Aptitude = "PER";
            this.Bonus_MondeNatal = "Teeming Masses in Metal Mountains";
            this.RefPage = 38;
            this.InfoModifCarac = "+AGI, +PER, -FM";
        }

    }
}
