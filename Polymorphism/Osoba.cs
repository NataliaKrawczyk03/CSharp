using System;
public class Osoba
    {
        private string imie;
        private string nazwisko;
        private string ulica;
        private string numer_ulicy;
        private string kod;
        private string miasto;
        
        public virtual void Wczytaj(){

            Console.WriteLine("Podaj dane osoby:");

            Console.Write("Imię:");
            imie = Console.ReadLine();
            Console.Write("Nazwisko: ");
            nazwisko = Console.ReadLine();
            Console.Write("Ulica: ");
            ulica = Console.ReadLine();
            Console.Write("Numer ulicy: ");
            numer_ulicy = Console.ReadLine();
            Console.Write("Kod pocztowy: ");
            kod = Console.ReadLine();
            Console.Write("Miasto: ");
            miasto = Console.ReadLine();
        }

        public virtual void Wyswietl()
        {
        Console.WriteLine("---------OSOBA---------");
        Console.WriteLine($"Imię: {imie}");
        Console.WriteLine($"Nazwisko: {nazwisko}");
        Console.WriteLine($"Ulica: {ulica} {numer_ulicy}");
        Console.WriteLine($"Kod pocztowy: {kod}");
        Console.WriteLine($"Miasto: {miasto}");
        }
    }
