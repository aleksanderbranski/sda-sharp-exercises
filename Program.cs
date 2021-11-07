using System;
using System.Text.RegularExpressions;

namespace sda_sharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EnterPassword("ee354$EW"));
        }

        static bool EnterPassword(string password)
        {
            return Regex.IsMatch(password, "[a-z]") && Regex.IsMatch(password, "[A-Z]") && Regex.IsMatch(password, "[&*$#]") && password.Length >= 6;
        }
        
    }
}
