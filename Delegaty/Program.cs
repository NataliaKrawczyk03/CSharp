using System;

class Program
{   
    //delagaty dla Zadanie_delegaty
    public delegate int Operacjai(int a);
    public delegate bool Operacjab(double a, double b);
    public delegate void Operacjav(int a);

    //delagat i funkcja dla Delegacje_zad
    public delegate bool Warunek(int a);

    public static void SprawdzTablice(int[] tablica, Warunek warunek)
    {
        int licznik = 0;
        foreach (int liczba in tablica)
        {
            if (warunek(liczba))
            {
                licznik++;
            }
        }

        Console.WriteLine($"Liczba elementów spełniających warunek: {licznik}");
    }


    // delegat i funkcje dla Zadanie_delegacje
    public delegate double OperacjaNaDouble(double x);
    
    public static void ModyfikujTablice(double[] tablica, OperacjaNaDouble operacja)
    {
        for (int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = operacja(tablica[i]);
        }
    }

    public static void Test()
    {
        Console.Write("Podaj rozmiar tablicy: ");
        int rozmiar = int.Parse(Console.ReadLine());

        double[] tablica = new double[rozmiar];
        Random rng = new Random();

        //wypełnianie tablicy losowymi wartościami z zakresu np. 1–10
        for (int i = 0; i < rozmiar; i++)
        {
            tablica[i] = rng.NextDouble() * 9 + 1;
        }

        Console.WriteLine("\nOryginalna tablica:");
        foreach (double val in tablica)
            Console.WriteLine(val);

        Console.Write("Podaj liczbę do mnożenia: ");
        double mnoznik = double.Parse(Console.ReadLine());

        OperacjaNaDouble odwrotnosc = x => 1.0 / x;
        OperacjaNaDouble mnozenie = x => x * mnoznik;

        ModyfikujTablice(tablica, mnozenie);
        Console.WriteLine("\nTablica po przemnożeniu przez " + mnoznik + ":");

        //ModyfikujTablice(tablica, odwrotnosc);
        //Console.WriteLine("\nTablica po zastosowaniu odwrotności:");
        
        foreach (double val in tablica)
            Console.WriteLine(val);
    }

    static void Main()
    {
        //zadanie_delegaty test
        Operacjai inkrementuj = x => x + 1;
        Operacjab porownaj = (a, b) => a == b;
        Operacjav wyswietl = a => Console.WriteLine($"Wartosc: {a}");

        Console.WriteLine("Inkrementacja 5: " + inkrementuj(5));
        Console.WriteLine("Czy 3.14 == 3.14? " + porownaj(3.14, 3.14)); 
        Console.WriteLine("Wypisywanie wartości 42:");
        wyswietl(42);

        //Delegaty_zad test
        Console.WriteLine("Podaj rozmiar tablicy:");
        int rozmiar = int.Parse(Console.ReadLine());

        int[] tablica = new int[rozmiar]; //tworzenie tablicy o zadanym rozmiarze
        
        Random rng = new Random();
        for (int i = 0; i < rozmiar; i++)
        {
            tablica[i] = rng.Next(0, 100); //losowe wartości 0–99
        }

        Console.Write("Podaj wartość progową: ");
        int prog = int.Parse(Console.ReadLine());
        Warunek warunek = x => x < prog;

        SprawdzTablice(tablica, warunek); //sprawdzanie ile wartosci tablicy jest ponizej progu

        //Zadanie_delegacje test

        Test();
    }
}
