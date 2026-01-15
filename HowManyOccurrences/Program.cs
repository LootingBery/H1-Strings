using System;

namespace HowManyOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HowManyOccurrences("do it now", "do"));
            Console.WriteLine(HowManyOccurrences("empty", "d"));
            Console.ReadLine();
        }

        public static int HowManyOccurrences(string text, string sub)
        {
            // Håndterer tomme strenge
            if (string.IsNullOrEmpty(sub) || string.IsNullOrEmpty(text))
                return 0;

            // Sætter vores midlertidige tæller og index
            int count = 0;
            int index = 0;

            // Bruger en while-løkke til at finde alle forekomster af sub i text
            while ((index = text.IndexOf(sub, index)) != -1)
            {
                count++;
                index += sub.Length;
            }

            return count;
        }

    }
}