using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    public class AttributArme
    {
        public string Nom { get; set; }
        public string Description { get; set; }

        public AttributArme()
        {

        }
        public AttributArme(string nom, string description)
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