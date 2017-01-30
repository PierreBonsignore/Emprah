using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    public class ArmeSpecial
    {
        public string Nom { get; set; }
        public string Description { get; set; }

        public ArmeSpecial()
        {

        }
        public ArmeSpecial(string nom, string description)
        {
            this.Nom = nom;
            this.Description = description;
        }
        public override string ToString()
        {
            return this.Nom;
        }
    }
}