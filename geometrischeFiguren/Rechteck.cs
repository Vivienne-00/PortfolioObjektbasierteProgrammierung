using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrischeFiguren
{
    public class Rechteck
    {
        private Linie linie1;
        private Linie linie2;
        private Linie linie3;
        private Linie linie4;
        public Rechteck(Linie linie1, Linie linie2)
        {
            this.linie1 = linie1;
            this.linie2 = linie2;
            this.linie3 = linie1;
            this.linie4 = linie2;
        }
        public double BerechneUmfang()
        {
            return linie1.Laenge + linie2.Laenge + linie3.Laenge + linie4.Laenge;
        }
        public double BerechneFlaeche()
        {
            return linie1.Laenge * linie2.Laenge;
        }

        public void RechteckAusgeben()
        {
            Console.WriteLine("Dies ist ein Rechteck.");
            Console.WriteLine("Es besteht aus 4 Linien:");
            Console.WriteLine($"Linie1 {linie1.Laenge} cm");
            Console.WriteLine($"Linie2 {linie2.Laenge} cm");
            Console.WriteLine($"Linie3 {linie3.Laenge} cm");
            Console.WriteLine($"Linie4 {linie4.Laenge} cm");
            Console.WriteLine("");
        }
    }
}
