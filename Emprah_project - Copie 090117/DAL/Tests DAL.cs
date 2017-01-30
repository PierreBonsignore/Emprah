using BO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [TestClass]
    public class Tests_DAL
    {
        #region Arme
        [TestMethod]
        public BindingList<Arme> ImportXml(FileStream flux)
        {
            return new ArmesDAL().ImportXML(flux);            
        }
        #endregion
    }
}
