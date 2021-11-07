using System;

namespace sda_sharp_exercises
{
    class Program
    {
        static char[] leetLetters = { '4', '3', '1', '0', '$' };
        static char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };

        static void Main(string[] args)
        {
            Console.WriteLine(ToLeet("Leeat"));
            Console.WriteLine(DeLeet("4$14 "));
        }

        static string ToLeet (string text)
        {
 
            string newtext = text;

            for (int i = 0; i < leetLetters.Length; i++)
            {
                newtext = newtext.Replace(naturalLetters[i], leetLetters[i]);
            }
            
            return newtext;
        }

        static string DeLeet(string text)
        {
        
            string newtext = text;

            for (int i = 0; i < leetLetters.Length; i++)
            {
                newtext = newtext.Replace(leetLetters[i], naturalLetters[i]);
            }

            return newtext;
        }
    }
}
