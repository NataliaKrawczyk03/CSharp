public struct Ulamek
{
    private int licznik;
    private int mianownik;

    public int Licznik
    {
        get => licznik;
        set => licznik = value;
    }

    public int Mianownik
    {
        get => mianownik;
        set
        {
            if (value == 0)
                throw new ArgumentException("Mianownik nie może być zerem!");
            mianownik = value;
        }
    }

    public Ulamek(int licznik, int mianownik)
    {
        if (mianownik == 0)
            throw new ArgumentException("Mianownik nie może być zerem!");

        this.licznik = licznik;
        this.mianownik = mianownik;
    }

    private int NWD(int a, int b)
    {
        while (b != 0)
        {
            int tmp = b;
            b = a % b;
            a = tmp;
        }
        return a;
    }
    public void Uprosc()
    {
        int nwd = NWD(licznik, mianownik);
        licznik = licznik / nwd;
        mianownik = mianownik / nwd;
    }
    public override string ToString()
    {
        return $"{licznik}/{mianownik}";
    }

    //operatory jednoargumentowe
    public static Ulamek operator -(Ulamek a) 
    {  
        return new Ulamek(-1*a.licznik, a.mianownik);
    }
    public static Ulamek operator +(Ulamek a) 
    {  
        return a;
    } 


    //operatory dwuargumentowe
    public static Ulamek operator +(Ulamek a, Ulamek b) 
    { 
        int l = a.licznik * b.mianownik + b.licznik * a.mianownik;
        int m = a.mianownik * b.mianownik;
        Ulamek wynik = new Ulamek(l, m);
        wynik.Uprosc();
        return wynik;
    }
    public static Ulamek operator -(Ulamek a, Ulamek b) 
    {  
        int l = a.licznik * b.mianownik - b.licznik * a.mianownik;
        int m = a.mianownik * b.mianownik;
        Ulamek wynik = new Ulamek(l, m);
        wynik.Uprosc();
        return wynik;
    }

    public static Ulamek operator *(Ulamek a, Ulamek b) 
    { 
        int l = a.licznik * b.licznik;
        int m = a.mianownik * b.mianownik;
        Ulamek u = new Ulamek(l,m);
        u.Uprosc();
        return u;
    }

    public static Ulamek operator /(Ulamek a, Ulamek b) 
    {  
        int l = a.licznik * b.mianownik;
        int m = a.mianownik * b.licznik;
        Ulamek u = new Ulamek(l,m);
        u.Uprosc();
        return u;
    }

    //operatory porownan
    public static bool operator ==(Ulamek a, Ulamek b) 
    {   
        a.Uprosc();
        b.Uprosc();
        return a.licznik == b.licznik && a.mianownik == b.mianownik;
    }

    public override bool Equals(object? obj)
    {
    if (obj is Ulamek u2)
    {
        Ulamek a = this;
        Ulamek b = u2;
        a.Uprosc();
        b.Uprosc();
        return a.licznik == b.licznik && a.mianownik == b.mianownik;
    }
    return false;
    }


    public static bool operator !=(Ulamek a, Ulamek b) 
    {
        a.Uprosc();
        b.Uprosc();
        return a.licznik != b.licznik || a.mianownik != b.mianownik;
    }

    public static bool operator <(Ulamek a, Ulamek b) 
    { 
        return a.Licznik * b.Mianownik < b.Licznik * a.Mianownik;
    }
    public static bool operator >(Ulamek a, Ulamek b) 
    {
        return a.Licznik * b.Mianownik > b.Licznik * a.Mianownik;
    }
    public static bool operator <=(Ulamek a, Ulamek b) 
    { 
        return a < b || a == b;
    }
    public static bool operator >=(Ulamek a, Ulamek b) 
    { 
        return a > b || a == b;
    }

    
}