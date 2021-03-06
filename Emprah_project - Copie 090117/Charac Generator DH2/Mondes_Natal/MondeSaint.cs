﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charac_Generator_DH2.Mondes_Natal
{
    class MondeSaint : Monde_Natal
    {
        public MondeSaint()
        {
            Dés jetDé = new Dés();
            this.InfoMond = "Monde gouverné par l'Ecclesiarchie où la dévotion à l'Empereur est forte.";
            this.DesignationMonde = "vient d'un Monde Saint.";
            this.PtsBlessuresBase = 7;
            this.PtsDestinBase = 3;
            this.EmpereurBenediction = 6;
            this.Aptitude = "FM";
            this.Bonus_MondeNatal = "Faith in the Creed";
            this.RefPage = 40;
            this.InfoModifCarac = "+SOC, +FM, -PER";
        }

    }
}
