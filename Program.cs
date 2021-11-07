using System;

namespace sda_sharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawTrg("*", 4);
        }

        static void DrawTrg(string symbol, int lineqty)
        {
            for (int i = 0; i < lineqty; i++)
            {
                for (int j = 0; j <= i ; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            for (int i = lineqty; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
