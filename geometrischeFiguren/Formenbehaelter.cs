using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrischeFiguren
{
    public class Formenbehaelter
    {
        public List<Rechteck> rechtecke = new List<Rechteck>();
        public List<Dreieck> dreiecke = new List<Dreieck>();
        public List<Kreis> kreise = new List<Kreis>();

        public Formenbehaelter(Rechteck Rechteck1, Rechteck Rechteck2, Kreis Kreis1)
        {
            rechtecke.Add(Rechteck1);
            rechtecke.Add(Rechteck2);
            kreise.Add(Kreis1);          
        }

        public void DreieckHinzufuegen(Dreieck dreieck)
        {
            if (dreiecke.Count < 4)
            {
                dreiecke.Add(dreieck);
            } 
            else
            {
                Console.WriteLine("Es wurde die Maximale Menge an Dreiecken erstellt, bitte löschen Sie einen.");
            }
        }
        public void KreisHinzufuegen(Kreis kreis)
        {
            if (kreise.Count < 3)
            {
                kreise.Add(kreis);
            } 
            else
            {
                Console.WriteLine("Es wurde die Maximale Menge an Kreisen erstellt, bitte löschen Sie einen.");
            }
        }

        public void DreieckErstesElementEntfernen()
        {
            if (dreiecke.Count > 0)
            {
                dreiecke.RemoveAt(0);
            } 
            else
            {
                Console.WriteLine("Es können keine Dreiecke mehr gelöscht werden.");
            }
        }

        public void KreisErstesElementEntfernen()
        {
            if (kreise.Count > 1)
            {
                kreise.RemoveAt(0);
            } 
            else
            {
                Console.WriteLine("Es können keine Kreise mehr gelöscht werden.");
            }
            
        }

        public void FormenbehaelterAusgeben()
        {
            Console.WriteLine("Der Formenbehälter enthält:");
            Console.WriteLine("");

            Console.WriteLine($"{kreise.Count} Kreise");
            Console.WriteLine("");
            kreise.ForEach(x =>  x.KreisAusgeben()) ;
            Console.WriteLine("");

            Console.WriteLine($"{rechtecke.Count} Rechtecke");
            Console.WriteLine("");
            rechtecke.ForEach(x => x.RechteckAusgeben());
            Console.WriteLine("");

            Console.WriteLine($"{dreiecke.Count} Dreiecke");
            Console.WriteLine("");
            dreiecke.ForEach(x => x.DreieckAusgeben());
            Console.WriteLine("");

        }
    }
}
