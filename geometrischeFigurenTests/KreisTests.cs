using Microsoft.VisualStudio.TestTools.UnitTesting;
using geometrischeFiguren;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrischeFiguren.Tests
{
    [TestClass()]
    public class KreisTests
    {
        [TestMethod()]
        public void BerechneFlaecheTest()
        {
            double umfang = 10;
            Kreis kreis = new Kreis(new Linie(umfang));
            double radius = umfang / (2 * Math.PI);
            double flaeche = Math.Pow(radius, 2) * Math.PI;
            Assert.AreEqual(flaeche, kreis.BerechneFlaeche());
        }

        [TestMethod()]
        public void BerechneUmfangTest()
        {
            double umfang = 23;
            Kreis kreis = new Kreis(new Linie(umfang));
            Assert.AreEqual(umfang, kreis.BerechneUmfang());
        }
    }
}