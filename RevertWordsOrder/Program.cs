using System;

namespace RevertWordsOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RevertWordsOrder("John Doe."));
            Console.WriteLine(RevertWordsOrder("A, B. C"));
            Console.ReadLine();
        }

        static string RevertWordsOrder(string input)
        {
            char[] delimiters = new char[] { ' ', ',', '.', '!', '?' };

            string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(words);

            return string.Join(" ", words);
        }
    }
}