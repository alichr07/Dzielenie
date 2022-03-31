using System;

namespace Dzielenie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sprawdzanie, czy druga liczba jest dzielnikiem pierwszej

            Console.WriteLine("Podaj liczbę całkowitą: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj kolejną liczbę całkowitą: ");
            int b = int.Parse(Console.ReadLine());
            if (a % b == 0)
            {
                Console.WriteLine("Liczba {1} jest dzielnikiem liczby {0}", a, b);
            }
            else
            {
                Console.WriteLine("Liczba {1} nie jest dzielnikiem liczby {0}", a, b);
            }
            Console.ReadKey();
        }
    }
}
