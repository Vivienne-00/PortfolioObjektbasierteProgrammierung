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
                switch (funktion)
                {
                    case "F":
                        formenbehaelter.FormenbehaelterAusgeben();
                        break;
                    case "RE":
                        formenbehaelter.RechteckErsetzen(new Rechteck(new Linie(17), new Linie(10)));
                        Console.WriteLine("Es wurde ein Rechteck ersetzt.");
                        break;
                    case "DH":
                        formenbehaelter.DreieckHinzufuegen(new Dreieck(new Linie(10), new Linie(10), new Linie(5)));
                        Console.WriteLine("Es wurde ein Dreieck hinzugefuegt.");
                        break;
                    case "KH":
                        formenbehaelter.KreisHinzufuegen(new Kreis(new Linie(10)));
                        Console.WriteLine("Es wurde ein Kreis hinzugefuegt.");
                        break;
                    case "DE":
                        formenbehaelter.DreieckErstesElementEntfernen();
                        Console.WriteLine("Es wurde ein Dreieck entfernt.");
                        break;
                    case "KE":
                        formenbehaelter.KreisErstesElementEntfernen();
                        Console.WriteLine("Es wurde ein Kreis entfernt.");
                        break;
                    case "RU":
                        double umfangRechteck = rechteck2.BerechneUmfang();
                        Console.WriteLine($"Der Umfang ist {umfangRechteck} cm.");
                        break;
                    case "RF":
                        double flaecheRechteck = rechteck2.BerechneFlaeche();
                        Console.WriteLine($"Die Flaeche ist {flaecheRechteck} cm\u00b2.");
                        break;
                    case "DU":
                        double umfangDreieck = dreieck1.BerechneUmfang();
                        Console.WriteLine($"Der Umfang ist {umfangDreieck} cm.");
                        break;
                    case "DF":
                        double flaecheDreieck = dreieck1.BerechneFlaeche();
                        Console.WriteLine($"Die Flaeche ist {flaecheDreieck} cm\u00b2.");
                        break;
                    case "KU":
                        double umfangKreis = kreis1.BerechneUmfang();
                        Console.WriteLine($"Der Umfang ist {umfangKreis} cm.");
                        break;
                    case "KF":
                        double flaecheKreis = kreis1.BerechneFlaeche();
                        Console.WriteLine($"Die Flaeche ist {flaecheKreis} cm\u00b2.");
                        break;
                    case "M":
                        ZeigeMenue();
                        break;
                    default:
                        Console.Write("Dies ist keine Funktion. Bitte geben Sie Ihre gewünschte Funktion ein.");
                        break;
                }

                funktion = Console.ReadLine();

            }

        }

        public static void ZeigeMenue()
        {
            Console.WriteLine("Herzlich Willkommen, bitte geben Sie Ihre gewuenschte Funktion ein:");
            Console.WriteLine("Formenbehaelter ausgeben: F");
            Console.WriteLine("Rechteck ersetzen: RE");
            Console.WriteLine("Dreieck hinzufuegen: DH");
            Console.WriteLine("Kreis hinzufuegen: KH");
            Console.WriteLine("erstes Dreieck entfernen: DE");
            Console.WriteLine("ersten Kreis entfernen: KE");
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