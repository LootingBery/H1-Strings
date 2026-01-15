namespace StringInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tilladere brugeren at give et input
            Console.WriteLine("Please provide at word you wish to be reversed!");
            string userInput = Console.ReadLine();
            string reversed = ReverseString(userInput);
            Console.WriteLine($"Reversed: {reversed}");
            Console.ReadLine();
        }

        static string ReverseString(string s)
        {
            // Bruger ToCharArray og Array.Reverse til at vende stringen
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
