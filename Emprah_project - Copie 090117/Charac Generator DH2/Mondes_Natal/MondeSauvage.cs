﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charac_Generator_DH2.Mondes_Natal
{
    class MondeSauvage : Monde_Natal
    {
     
        public MondeSauvage()
        {
            Dés jetDé = new Dés();
            this.InfoMond = "Un monde dépourvu de civilisation où les plus forts survivent.";
            this.DesignationMonde = "vient d'un Monde Sauvage.";
            this.PtsBlessuresBase = 9;
            this.PtsDestinBase = 2;
            this.EmpereurBenediction = 3;
            this.Aptitude = "END";
            this.Bonus_MondeNatal = "The Old Ways";
            this.RefPage = 32;            
            this.InfoModifCarac = "+FOR, +END, -INF";
        }
    }
}
