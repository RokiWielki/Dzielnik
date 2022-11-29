//Napisz program pobierający od użytkownika dwie liczby całkowite. Program powinien
//wyświetlać informację, czy druga liczba jest dzielnikiem pierwszej.
using System;

namespace Dzielnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b :");
            int b = int.Parse(Console.ReadLine());
            if (a % b == 0)
            {
                Console.WriteLine(b+" Jest dzielnikiem liczby "+a);
            }
            else Console.WriteLine(b+" nie jest dzielnikiem liczby "+a);

        }
        
    }
}
