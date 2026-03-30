using System;
using System.Runtime.CompilerServices;

class Program
{

    static void Main(string[] args) // <- to jest metoda, ona należy do klasy
    {
        Console.WriteLine("Ile masz lat?");
        int wiek = int.Parse(Console.ReadLine()); //integer czyli liczby całkowie "Z". Czytaj z konsoli i konwertuj tekst na liczbę całkowitą.

        if (wiek >= 18) //jezeli zmienna wiek jest większa lub równa 18 to wykonaj instrukcję
        {
            Console.WriteLine("Może być, wchodzisz.");
            Console.WriteLine("Wybierz działanie:");
            Console.WriteLine("1 - Dodawanie");
            Console.WriteLine("2 - Mnożenie");
            Console.WriteLine("3 - sprawdź czy liczba jest parzysta");
            int wybor = int.Parse(Console.ReadLine());

            if (wybor == 1) // dodawanie
            {
                Console.WriteLine("Dodawanie. Podaj pierwszą liczbe i wciśniej enter:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę i wcisnij enter:");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Suma:");
                int wynik_dodawania = Dodawanie(a, b);
                Console.WriteLine(wynik_dodawania);
            } else if (wybor == 2) // mnozenie
            {
                Console.WriteLine("Mnożenie. Poadaj pierwszą liczbę i naciśnij enter:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę i naciśnij enter:");
                int b = int.Parse(Console.ReadLine());
                int wynik_mnozenia = Mnozenie(a, b);
                Console.WriteLine($"Iloczyn: {wynik_mnozenia}");
            }  else if (wybor == 3) // czy parzysta
            {
                Console.WriteLine("Czy liczba parzysta? Podaj liczbę i wciśnij enter:");
                int n = int.Parse(Console.ReadLine());
                bool tf_parzysta = CzyParzysta(n);
                if (tf_parzysta == true)
                {
                  Console.WriteLine("Wynik: Parzysta");
                } else
                { Console.WriteLine("Wynik: Nieparzysta"); }
            }  
        } else 
            {
                Console.WriteLine("Dla Ciebie zamknięte.");
            }      
    }

static int Dodawanie(int a, int b)
{
    return a + b;
}

static int Mnozenie(int a, int b)
    {
        return a * b;
    }
static bool CzyParzysta(int n)
    {
        return n % 2 == 0;
    }

static void Zmien(int x) //<-- static void bo nie używamy return. jeżeli wpisałbym (ref int x), to wtedy zmienna x byłaby modyfikowana przez x = 100 - opis niżej
{
    x = 100; //<-- to, że se tu wpisałem 100, nie wpływa na zmienną x podaną w argumencie metody (int x), więc oryginał zawsze zostanie X, bo operujemy na kopii.
}

}