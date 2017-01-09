using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
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
            return string.Format("\"{0}\":\n{1}", this.Nom, this.Description);
        }
    }
}