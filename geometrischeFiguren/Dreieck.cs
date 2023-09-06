using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrischeFiguren
{
    public class Dreieck
    {
        private Linie linie1;
        private Linie linie2;
        private Linie linie3;
        public Dreieck(Linie linie1, Linie linie2, Linie linie3)
        {
            this.linie1 = linie1;
            this.linie2 = linie2;
            this.linie3 = linie3;
        }
        public double BerechneUmfang()
        {
            return linie1.Laenge + linie2.Laenge + linie3.Laenge; ;
        }

        public double BerechneFlaeche()
        {
            double halbumfang = BerechneUmfang() / 2;
            return Math.Sqrt(halbumfang * (halbumfang - linie1.Laenge) * (halbumfang - linie2.Laenge) * (halbumfang - linie3.Laenge));
        }

        public void DreieckAusgeben()
        {
            Console.WriteLine("Dies ist ein Dreieck.");
            Console.WriteLine("Es besteht aus 3 Linien:");
            Console.WriteLine($"Linie1 {linie1.Laenge} cm");
            Console.WriteLine($"Linie2 {linie2.Laenge} cm");
            Console.WriteLine($"Linie3 {linie3.Laenge} cm");
            Console.WriteLine("");
        }

    }
}
