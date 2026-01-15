using System;

namespace SortCharactersDescending
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortCharactersDescending("onomatopoeia"));
            Console.WriteLine(SortCharactersDescending("fohjwf42os"));
            Console.ReadLine();
        }

        public static string SortCharactersDescending(string text)
        {
            char[] chars = text.ToCharArray(); // Tekst til char array
            Array.Sort(chars); // Sortere arrayen
            Array.Reverse(chars); // Vender arrayen
            return new string(chars);
        }

    }
}