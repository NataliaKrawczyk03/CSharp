public class Program
{
    public static void Main()
    {

        Console.WriteLine("##########TESTY STOS##########");
        // Test dla int
        Stos<int> stosLiczb = new Stos<int>();

        Console.WriteLine("Dodanie 10, 20, 30 na stos...");
        stosLiczb.Push(10);
        stosLiczb.Push(20);
        stosLiczb.Push(30);

        Console.WriteLine("Zawartość stosu: " + stosLiczb);
        Console.WriteLine("Peek: " + stosLiczb.Peek());
        Console.WriteLine("Pop: " + stosLiczb.Pop());
        Console.WriteLine("Zawartość stosu po Pop: " + stosLiczb);

        Console.WriteLine("Czy stos jest pusty? " + stosLiczb.IsEmpty);
        Console.WriteLine("Ilość elementów: " + stosLiczb.Count);

        // Test dla string
        Stos<string> stosStringow = new Stos<string>();
        stosStringow.Push("Ala");
        stosStringow.Push("ma");
        stosStringow.Push("kota");

        Console.WriteLine("Stos stringów: " + stosStringow);

        Console.WriteLine("##########TESTY TABLICA##########");
        // Test dla int
        var tablicaInt = new TablicaGeneryczna<int>(5);
        
        tablicaInt.Ustaw(0, 10);
        tablicaInt.Ustaw(1, 20);
        tablicaInt.Ustaw(2, 30);
        
        Console.WriteLine($"Wartość na indeksie 0: {tablicaInt.Pobierz(0)}");
        Console.WriteLine($"Wartość na indeksie 1: {tablicaInt.Pobierz(1)}");
        Console.WriteLine($"Wartość na indeksie 2: {tablicaInt.Pobierz(2)}");
        
        // Test dla string
        var tablicaString = new TablicaGeneryczna<string>(3);
        
        tablicaString.Ustaw(0, "Hello");
        tablicaString.Ustaw(1, "World");
        
        Console.WriteLine($"Wartość na indeksie 0: {tablicaString.Pobierz(0)}");
        Console.WriteLine($"Wartość na indeksie 1: {tablicaString.Pobierz(1)}");
    }
}
