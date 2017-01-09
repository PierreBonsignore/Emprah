using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charac_Generator_DH2.Equipements.Armes
{
    abstract class _ArmeADistance: _Arme
    {
        private _Cadence cadence;
        private int portée;

        public _Cadence Cadence
        {
            get
            {
                return cadence;
            }

            set
            {
                cadence = value;
            }
        }
    }
}
