using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BO
{
    public class MondeForge : Monde_Natal
    {

        public MondeForge()
        {
            this.InfoMond = "Monde dirigé par le Mechanicus tourné vers la technologie.";
            this.DesignationMonde = "vient d'un Monde Forge.";
            this.PtsBlessuresBase = 8;
            this.PtsDestinBase = 3;
            this.EmpereurBenediction = 8;
            this.Aptitude = "INT";
            this.Bonus_MondeNatal = "Omnissiah Chosen";
            this.RefPage = 34;
            this.InfoModifCarac = "+INT, +END, -SOC";
        }
    }
}
