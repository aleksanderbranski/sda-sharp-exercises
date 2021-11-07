using System;

namespace sda_sharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz cenę");
            int pc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wpisz ilość");
            int qty = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= qty; i++)
            {
                Console.WriteLine($"Liczba sztuk: {i}; łączna cena: {pc * i}");
            }
           
        }
    }
}
