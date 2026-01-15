using System;
using System.Reflection.PortableExecutable;

namespace NumbersOfWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumbersOfWords("This is sample sentence"));

            Console.WriteLine(NumbersOfWords("OK"));
            Console.ReadLine();
        }

        static int NumbersOfWords(string input)
        {
            int length = 0;
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    length++;
                }
            }
            return length + 1;
        }
    }
}