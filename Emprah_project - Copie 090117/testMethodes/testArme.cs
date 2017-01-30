using BO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testMethodes
{
    [TestClass]
    class testArme
    {
        [TestMethod]
        public void testNom()
        {
            Assert.IsNotNull(new { nom = 2 });
        }

        [TestMethod]
        public void testType()
        {

        }
    }
}
