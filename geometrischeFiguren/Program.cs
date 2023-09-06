namespace geometrischeFiguren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZeigeMenue();
            string funktion = Console.ReadLine();
            Rechteck rechteck1 = new Rechteck(new Linie(5), new Linie(4));
            Rechteck rechteck2 = new Rechteck(new Linie(9), new Linie(6));
            Kreis kreis1 = new Kreis(new Linie(10));
            Kreis kreis2 = new Kreis(new Linie(15));
            Dreieck dreieck1 = new Dreieck(new Linie(7), new Linie(7), new Linie(5));

            Formenbehaelter formenbehaelter = new Formenbehaelter(rechteck1, rechteck2, kreis1);

            formenbehaelter.KreisHinzufuegen(kreis2);
            formenbehaelter.DreieckHinzufuegen(dreieck1);


            while (funktion != "Q")
            {
                if (funktion == "F")
                {
                    formenbehaelter.FormenbehaelterAusgeben();
                }
                else if (funktion == "DH")
                {
                    formenbehaelter.DreieckHinzufuegen(new Dreieck(new Linie(10), new Linie(10), new Linie(5)));
                }
                else if (funktion == "KH")
                {
                    formenbehaelter.KreisHinzufuegen(new Kreis(new Linie(10)));
                }
                else if (funktion == "DL")
                {
                    formenbehaelter.DreieckErstesElementEntfernen();
                }
                else if (funktion == "KL")
                {
                    formenbehaelter.KreisErstesElementEntfernen();
                }
                else if (funktion == "RU")
                {
                    rechteck2.BerechneUmfang();
                }
                else if (funktion == "RF")
                {
                    rechteck2.BerechneFlaeche();
                }
                else if (funktion == "DU")
                {
                    dreieck1.BerechneUmfang();
                }
                else if (funktion == "DF")
                {
                    dreieck1.BerechneFlaeche();
                }
                else if (funktion == "KU")
                {
                    kreis1.BerechneUmfang();
                }
                else if (funktion == "KF")
                {
                    kreis1.BerechneFlaeche();
                }
                else if (funktion == "M")
                {
                    ZeigeMenue();
                }
                else
                {
                    Console.Write("Dies ist keine Funktion. Bitte geben Sie Ihre gewünschte Funktion ein.");
                }

                funktion = Console.ReadLine();

            }

        }

        public static void ZeigeMenue()
        {
            Console.WriteLine("Herzlich Willkommen, bitte geben Sie Ihre gewuenschte Funktion ein:");
            Console.WriteLine("Formenbehaelter ausgeben: F");
            Console.WriteLine("Dreieck hinzufuegen: DH");
            Console.WriteLine("Kreis hinzufuegen: KH");
            Console.WriteLine("erstes Dreieck loeschen: DL");
            Console.WriteLine("ersten Kreis loeschen: KL");
            Console.WriteLine("berechne Umfang Rechteck: RU");
            Console.WriteLine("berechne Flaeche Rechteck: RF");
            Console.WriteLine("berechne Umfang Dreieck: DU");
            Console.WriteLine("berechne Flaeche Dreieck: DF");
            Console.WriteLine("berechne Umfang Kreis: KU");
            Console.WriteLine("berechne Flaeche Kreis: KF");
            Console.WriteLine("Menue anzeigen: M");
            Console.WriteLine("Aufhoeren: Q");
        }
    }
}