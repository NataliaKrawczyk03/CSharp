using System;
class Program
{
    static void Main(string[] args)
    {

        Kadra kadra = new Kadra();

        kadra.Wczytaj();

        kadra.Wyswietl();

        Osoba osoba = new Kadra();  // Typ Osoba, ale obiekt 'Kadra'

        // Wywolanie metod przez zmienną typu Osoba
        osoba.Wczytaj();  // wywola metode Wczytaj() z klasy Kadra
        osoba.Wyswietl();

    }
}