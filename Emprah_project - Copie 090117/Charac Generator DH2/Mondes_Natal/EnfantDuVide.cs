using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charac_Generator_DH2.Mondes_Natal
{
    class EnfantDuVide : Monde_Natal
    {
        public EnfantDuVide()
        {
            Dés jetDé = new Dés();
            this.InfoMond = "Ceux qui sont nés et ont vécu dans les vaisseaux et stations spatiales.";
            this.DesignationMonde = " est un Enfant du Vide.";
            this.PtsBlessuresBase = 7;
            this.PtsDestinBase = 3;
            this.EmpereurBenediction = 5;
            this.Aptitude = "INT";
            this.Bonus_MondeNatal = "Child of the Dark";
            this.RefPage = 42;
            this.InfoModifCarac = "+INT, +FM, -FOR";
        }

    }
}
