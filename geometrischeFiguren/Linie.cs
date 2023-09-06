using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrischeFiguren
{
    public class Linie
    {
        private double laenge;

        public double Laenge { get { return laenge; } }

        public Linie(double laenge)
        {
            if (laenge > 0)
            {
                this.laenge = laenge;
            }
            else
            {
                Console.WriteLine("Eingabe ist ungültig, bitte geben Sie die Länge nochmals neu ein.");
            }
        }
    }
}
