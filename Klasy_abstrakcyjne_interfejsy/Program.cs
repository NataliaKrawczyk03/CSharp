using System;
class Program
{
    static void Main(string[] args)
    {
        // Polimorfizm i klasa abstrakcyjna
         OsobaOgólna osoba = new Kadra();

        osoba.Wczytaj();
        osoba.Wyswietl();

        //Interfejs
        Kadra kadra1 = new Kadra();
        kadra1.Wczytaj();
        Kadra kadra2 = new Kadra();
        kadra2.Wczytaj();

        if (kadra1.CzyEmailWypelniony())
        {
            Console.WriteLine("Email w kadrze został podany.");
        }
        else
        {
            Console.WriteLine("Email w kadrze NIE został podany.");
        }

        if (kadra1.CzyEmailTakiSam(kadra2))
        {
            Console.WriteLine("Oba obiekty mają ten sam adres email.");
        }
        else
        {
            Console.WriteLine("Obiekty mają różne adresy email.");
        }

    }
}