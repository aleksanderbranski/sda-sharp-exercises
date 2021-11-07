using System;

namespace sda_sharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }

        static int Factorial(int number)
        {
            if (number <0)
            {
                throw new ArgumentException("Liczba musi być większa niż 0");
            }
            
            int result = 1;

            for (int i = number; i >1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
