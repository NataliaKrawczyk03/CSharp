public class Stos<T>
{
    private List<T> elementy = new List<T>(); //koniec listy to szczyt stosu

    //dodawanie elementow
    public void Push(T element)
    {
        elementy.Add(element);
    }

    public T Pop()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Stos jest pusty!");

        T top = elementy[elementy.Count - 1];
        elementy.RemoveAt(elementy.Count - 1); //usuwamy ostatni elememt
        return top; //ale zwracamy jego wartosc
    }

    public T Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Stos jest pusty!");

        return elementy[elementy.Count - 1]; //zwrocenie ostatniego elementu
    }

    public int Count => elementy.Count;

    public bool IsEmpty => elementy.Count == 0;

    public override string ToString()
    {
        return $"[{string.Join(", ", elementy)}]";
    }
}