using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charac_Generator_DH2.Mondes_Natal
{
    class HauteNaissance : Monde_Natal
    {
        public HauteNaissance()
        {
            Dés jetDé = new Dés();
            this.InfoMond = Traduction.HauteNaissance;
            this.DesignationMonde = "est de Haute Naissance.";
            this.PtsBlessuresBase = 9;
            this.PtsDestinBase = 4;
            this.EmpereurBenediction = 10;
            this.Aptitude = "SOC";
            this.Bonus_MondeNatal = "Breeding Counts";
            this.RefPage = 36;
            this.InfoModifCarac = "+SOC, +INF, -END";
        }

    }
}
