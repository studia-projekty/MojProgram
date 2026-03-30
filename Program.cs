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

            if (wybor = 1)
            {
                Console.WriteLine("Dodawanie. Podaj pierwszą liczbe i wciśniej enter:")
            }

            Console.WriteLine("Wynik 2+3:");
            int wynik = Dodaj(2, 3);
            Console.WriteLine(wynik);
        } else //jeżeli inaczej, to wykonaj instrukcję
        {
            Console.WriteLine("Dla Ciebie zamknięte.");
        }
             
    }
    
    static int Dodawanie(int a, int b)
    {
        return a + b;
    }
    static void Zmien(int x) //<-- jeżeli wpisałbym (ref int x), to wtedy zmienna x byłaby modyfikowana przez x = 100 - opis niżej
    {
        x = 100; //<-- to, że se tu wpisałem 100, nie wpływa na zmienną x podaną w argumencie metody (int x), więc oryginał zawsze zostanie X, bo operujemy na kopii.
    }

static void Mnozenie(int a, int b)
    {
        return a * b;
    }
static bool CzyParzysta(int n)
    {
        return n % 2 == 0;
    }

}