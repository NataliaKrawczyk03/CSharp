using System;
public class Kadra : Osoba, IEmail, ISameEmail
{
    private string wyksztalcenie;
    private string stanowisko;
    private string pesel;

    public override void Wczytaj()
    {
        base.Wczytaj();

        Console.Write("Wykształcenie: ");
        wyksztalcenie = Console.ReadLine();
        Console.Write("Stanowisko: ");
        stanowisko = Console.ReadLine();

        bool poprawnyPesel = false;
        while (!poprawnyPesel)
        {
            Console.Write("PESEL (11 cyfr): ");
            pesel = Console.ReadLine();
            poprawnyPesel = SprawdzPoprawnoscPesel(pesel);

            if (!poprawnyPesel)
            {
                Console.WriteLine("Numer PESEL jest niepoprawny. Proszę spróbować ponownie.");
            }
        }
    }
        
    public override void Wyswietl()
    {
        base.Wyswietl();

        Console.WriteLine($"Wykształcenie: {wyksztalcenie}");
        Console.WriteLine($"Stanowisko: {stanowisko}");
        Console.WriteLine($"PESEL: {pesel}");
    }

    public bool SprawdzPoprawnoscPesel(string pesel)
    {
        // Dlugosc 11
        if (pesel.Length != 11)
        {
            return false;
        }

        // Tylko cyfry
        foreach (char c in pesel)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }

        // Sprawdzenie poprawnosci, sumy kontrolnej PESEL
        // https://www.gov.pl/web/gov/czym-jest-numer-pesel
        int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 };
        int sumaKontrolna = 0;
        for (int i = 0; i < 10; i++)
        {
            sumaKontrolna += (pesel[i] - '0') * wagi[i];
        }
        int kontrolna = (10 - (sumaKontrolna % 10)) % 10;

        return kontrolna == (pesel[10] - '0');
    }

    

    
}

