using System;

class Program
{
    static void Main()
    {
        Ulamek u1 = new Ulamek(1, 2);
        Ulamek u2 = new Ulamek(2, 4);
        Ulamek u3 = new Ulamek(3, 4);
        Ulamek u4 = new Ulamek(-1, 2);

        Console.WriteLine($"u1: {u1}");
        Console.WriteLine($"u2: {u2}"); 

        // Equals ==
        Console.WriteLine($"u1 == u2: {u1 == u2}");
        Console.WriteLine($"u1.Equals(u2): {u1.Equals(u2)}");

        // !=
        Console.WriteLine($"u1 != u3: {u1 != u3}");

        // +
        Ulamek suma = u1 + u3;
        Console.WriteLine($"u1 + u3 = {suma}");

        // -
        Ulamek roznica = u3 - u1;
        Console.WriteLine($"u3 - u1 = {roznica}"); 

        // *
        Ulamek iloczyn = u1 * u3;
        Console.WriteLine($"u1 * u3 = {iloczyn}"); 

        // /
        Ulamek iloraz = u1 / u3;
        Console.WriteLine($"u1 / u3 = {iloraz}"); 

        // Operatory jednoargumentowe
        Console.WriteLine($"-u1 = {-u1}"); 
        Console.WriteLine($"+u1 = {+u1}"); 

        // Operatory porownania
        Console.WriteLine($"u1 < u3: {u1 < u3}");  
        Console.WriteLine($"u3 > u1: {u3 > u1}");  
        Console.WriteLine($"u1 <= u2: {u1 <= u2}"); 
        Console.WriteLine($"u1 >= u2: {u1 >= u2}"); 

        // Obsluga wyjatku
        try
        {
            Ulamek blad = new Ulamek(1, 0); 
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Błąd: {e.Message}");
        }
    }
}
