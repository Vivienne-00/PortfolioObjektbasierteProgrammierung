using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrischeFiguren
{
    public class Kreis
    {
        private Linie umfang;
        public Kreis(Linie umfang)
        {
            this.umfang = umfang;
        }

        public double BerechneUmfang()
        {
            return umfang.Laenge;
        }

        public double BerechneFlaeche()
        {
            double PI = Math.PI;
            double durchmesser = umfang.Laenge / PI;
            return PI * (durchmesser * durchmesser / 4);
        }

        public void KreisAusgeben()
        {
            Console.WriteLine("Dies ist ein Kreis.");
            Console.WriteLine("Es besteht aus 1 Linie, dies ist der Umfang:");
            Console.WriteLine($"Umfang {umfang.Laenge} cm");
            Console.WriteLine("");
        }

    }
}
