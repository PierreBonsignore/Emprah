using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charac_Generator_DH2.Equipements
{
    abstract class _Arme : Equipement
    {
        private int degats;

        public int Degats
        {
            get
            {
                return degats;
            }

            set
            {
                degats = value;
            }
        }
    }
}
