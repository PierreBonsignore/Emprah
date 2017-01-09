using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public enum TypeRech
    {
        DemiAction,
        Action
    }
    public class Rech
    {
        public int nbAction;
        public TypeRech type;

        #region Constructeurs
        public Rech()
        {

        }
        public Rech(int nb, TypeRech typeRech)
        {
            this.nbAction = nb;
            this.type = typeRech;
        } 
        #endregion

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            if (nbAction>0)
            {
                s.Append(nbAction + " ");
            }
            s.Append(type);
            return s.ToString();
        }
    }
}