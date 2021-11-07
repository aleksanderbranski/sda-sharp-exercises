using System;

namespace sda_sharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ToLeet("Leeat");
            DeLeet("4$14 ");
        }

        static void ToLeet (string text)
        {
             char[] leetLetters = { '4', '3', '1', '0', '$' };
             char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };

          
            string newtext = text;

            for (int i = 0; i < leetLetters.Length; i++)
            {
                newtext = newtext.Replace(naturalLetters[i], leetLetters[i]);
            }
            
          
          
            Console.WriteLine(newtext);
        }

        static void DeLeet(string text)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };


            string newtext = text;

            for (int i = 0; i < leetLetters.Length; i++)
            {
                newtext = newtext.Replace(leetLetters[i], naturalLetters[i]);
            }



            Console.WriteLine(newtext);
        }
    }
}
