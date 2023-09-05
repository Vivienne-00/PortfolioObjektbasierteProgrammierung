using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrischeFiguren
{
    internal class Formenbehaelter
    {
        public List<Rechteck> rechtecke = new List<Rechteck>();
        public List<Dreieck> dreiecke = new List<Dreieck>();
        public List<Kreis> kreise = new List<Kreis>();

        private Rechteck rechteck1;
        private Rechteck rechteck2;
        private Kreis kreis1;

        public Formenbehaelter(Rechteck Rechteck1, Rechteck Rechteck2, Kreis Kreis1)
        {
            this.rechteck1 = Rechteck1;
            this.rechteck2 = Rechteck2;
            this.kreis1 = Kreis1;
        }

        //Folgende Funktionen müssen noch bearbeitet werden:
        public void DreieckHinzufuegen(Dreieck dreieck)
        {
            dreiecke.Add(dreieck);
        }
        public void KreisHinzufuegen(Kreis kreis)
        {
            kreise.Add(kreis);
        }

        public void DreieckLetztesElementEntfernen(Dreieck dreieck)
        {
            dreiecke.RemoveAt(dreiecke.Count - 1);
        }

        public void KreisLetztesElementEntfernen(Kreis kreis)
        {
            kreise.RemoveAt(kreise.Count - 1);
        }
    }
}
