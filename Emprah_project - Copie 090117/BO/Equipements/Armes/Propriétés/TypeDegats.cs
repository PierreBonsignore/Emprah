using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;

namespace BO
{   
    [Serializable]
    public enum TypeDegats
    {
        Energie,
        Impact,
        Dechirant,
        Explosif
    }

   
}