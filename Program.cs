using System;

namespace sda_sharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(AProg(3, 1, 2)[i]);
            }
        }

        static int[] AProg(int length, int start, int diff)
        {
            int []result = new int [length];

            for (int i = 0; i < length; i++)
            {
                if (i==0)
                {
                    result[i] = start;
                }
                else
                {
                    result[i] = result[i-1]+ diff;
                    
                }
                
            }
            return result;
        }

    }
}
