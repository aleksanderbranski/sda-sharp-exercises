using System;

namespace sda_sharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj podstawę");
            int basis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj wykładnik");
            int exp = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            if (exp>0)
            {
                for (int i = 0; i < exp; i++)
                {
                     result *= basis;
                }

                Console.WriteLine(result);
            }
            else if (exp<0)
            {
                for (int i = 0; i < exp; i++)
                {
                    result *= (1/basis);
                }

                Console.WriteLine(result);
            }
            else
                Console.WriteLine("1");
        }
    }
}
