using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrischeFiguren
{
    internal class Kreis
    {
        private Linie durchmesser;
        public Kreis(Linie Durchmesser)
        {
          this.durchmesser = Durchmesser;
        }

        public double BerechneUmfang()
        {
            double PI = Math.PI;
            return durchmesser.Laenge * PI;
        }

        public double BerechneFlaeche()
        {
            double PI = Math.PI;
            return PI * (durchmesser.Laenge * durchmesser.Laenge / 4);
        }

    }
}
