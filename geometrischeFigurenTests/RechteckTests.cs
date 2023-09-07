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
    public class RechteckTests
    {
        [TestMethod()]
        public void BerechneFlaecheTest()
        {
            double linie1 = 15;
            double linie2 = 10;
            Rechteck rechteck = new Rechteck(new Linie(linie1), new Linie(linie2));
            double flaeche = linie1 * linie2;
            Assert.AreEqual(flaeche, rechteck.BerechneFlaeche());
        }
    }
}