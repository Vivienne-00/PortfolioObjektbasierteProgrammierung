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

        /// <summary>
        /// Dies ist der Formenbehaelter. 
        /// Dieser Behaelter benoetigt mindestens zwei Rechtecke und einen Kreis.
        /// </summary>
        public Formenbehaelter(Rechteck rechteck1, Rechteck rechteck2, Kreis kreis1)
        {
            rechtecke.Add(rechteck1);
            rechtecke.Add(rechteck2);
            kreise.Add(kreis1);          
        }

        /// <summary>
        /// Das ist eine Methode für das Ersetzen eines Rechtecks aus der Liste rechtecke.
        /// Das Hinzufuegen und Loeschen wurde nicht in separate Methoden aufgeteilt,
        /// da der Formenbehaelter jeweils zwei Rechtecke benötigt.
        /// </summary>
        public void RechteckErsetzen(Rechteck rechteck)
        {
            rechtecke.RemoveAt(0);
            rechtecke.Add(rechteck);
        }

        public void DreieckHinzufuegen(Dreieck dreieck)
        {
            if (dreiecke.Count < 4)
            {
                dreiecke.Add(dreieck);
            } 
            else
            {
                Console.WriteLine("Es wurde die Maximale Menge an Dreiecken erstellt, bitte loeschen Sie einen.");
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
                Console.WriteLine("Es wurde die Maximale Menge an Kreisen erstellt, bitte loeschen Sie einen.");
            }
        }

        /// <summary>
        /// Das ist eine Methode für das entfernen des ersten Dreiecks aus der Liste dreiecke.
        /// Zuerst wird geprüft ob sich in der Liste noch Dreicke befinden.
        /// Falls es in der Liste noch hat, wird das erste Dreieck in der Liste geloescht. 
        /// Ansonsten wird der Benutzer mit einem Konsoleneintrag informiert, dass keine Dreiecke mehr gelöscht werden können.
        /// </summary>
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
            if (kreise.Count > 1)
            {
                Console.WriteLine($"{kreise.Count} Kreise");
                Console.WriteLine("");
                kreise.ForEach(x => x.KreisAusgeben());
                Console.WriteLine("");
            } else
            {
                Console.WriteLine($"{kreise.Count} Kreis");
                Console.WriteLine("");
                kreise.ForEach(x => x.KreisAusgeben());
                Console.WriteLine("");
            }
            
            Console.WriteLine($"{rechtecke.Count} Rechtecke");
            Console.WriteLine("");
            rechtecke.ForEach(x => x.RechteckAusgeben());
            Console.WriteLine("");

            if (dreiecke.Count > 1)
            {
                Console.WriteLine($"{dreiecke.Count} Dreiecke");
                Console.WriteLine("");
                dreiecke.ForEach(x => x.DreieckAusgeben());
                Console.WriteLine("");
            } else
            {
                Console.WriteLine($"{dreiecke.Count} Dreieck");
                Console.WriteLine("");
                dreiecke.ForEach(x => x.DreieckAusgeben());
                Console.WriteLine("");
            }
            
        }
    }
}
