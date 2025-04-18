public class TablicaGeneryczna<T>
{
    private T[] tablica;

    public TablicaGeneryczna(int rozmiar)
    {
        tablica = new T[rozmiar];
    }

    public T Pobierz(int index)
    {
        if (index < 0 || index >= tablica.Length)
        {
            throw new IndexOutOfRangeException("Indeks poza zakresem tablicy.");
        }
        return tablica[index];
    }

    public void Ustaw(int index, T wartosc)
    {
        if (index < 0 || index >= tablica.Length)
        {
            throw new IndexOutOfRangeException("Indeks poza zakresem tablicy.");
        }
        tablica[index] = wartosc;
    }
}