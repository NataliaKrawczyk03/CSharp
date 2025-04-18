using System;
public class Osoba : OsobaOgólna, IEmail, ISameEmail
    {
        private string imie;
        private string nazwisko;
        private string ulica;
        private string numer_ulicy;
        private string kod;
        private string miasto;
        private string email;
        public string Email => email; //wartosc na zewnatrz tylko do oczytu

        public override void Wczytaj(){

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
            Console.Write("Email: ");
            email = Console.ReadLine();
        }

        public override void Wyswietl()
        {
        Console.WriteLine("---------OSOBA---------");
        Console.WriteLine($"Imię: {imie}");
        Console.WriteLine($"Nazwisko: {nazwisko}");
        Console.WriteLine($"Ulica: {ulica} {numer_ulicy}");
        Console.WriteLine($"Kod pocztowy: {kod}");
        Console.WriteLine($"Miasto: {miasto}");
        Console.WriteLine($"Email: {email}");
        }

        public bool CzyEmailWypelniony()
        {
        return !string.IsNullOrWhiteSpace(email); // true jeśli nie jest null, pusty, albo samymi spacjami
        }

        public bool CzyEmailTakiSam(IEmail innaOsoba)
        {
             return this.Email == innaOsoba.Email;
        }
    }
