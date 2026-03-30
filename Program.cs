using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ile masz lat?");
        int wiek = int.Parse(Console.ReadLine()); //integer czyli liczby całkowie "Z". Czytaj z konsoli i konwertuj tekst na liczbę całkowitą.
        {         
            if (wiek >= 18) //jezeli zmienna wiek jest większa lub równa 18 to wykonaj instrukcję
            {
                Console.WriteLine("Może być, wchodzisz.");
            } else //jeżeli inaczej, to wykonaj instrukcję
            {
                Console.WriteLine("Dla Ciebie zamknięte.");
            }
        }
        
    }
}