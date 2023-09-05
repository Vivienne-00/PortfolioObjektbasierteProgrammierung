using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrischeFiguren
{
    internal class Rechteck
    {
        private Linie linie1;
        private Linie linie2;
        private Linie linie3;
        private Linie linie4;
        public Rechteck(Linie Linie1, Linie Linie2)
        {
            this.linie1 = Linie1;
            this.linie2 = Linie2;
            this.linie3 = Linie1;
            this.linie4 = Linie2;
        }
        public double BerechneUmfang()
        {
            return linie1.Laenge + linie2.Laenge + linie3.Laenge + linie4.Laenge;
        }
        public double BerechneFlaeche()
        {
            return linie1.Laenge * linie2.Laenge;
        }
    }
}
