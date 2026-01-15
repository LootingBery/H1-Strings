namespace LengthOfAString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Jeg ladere brugeren give et input (Jeg følger det er sjovere end at hardcode det)
            Console.WriteLine("Please provide a word or a random scribble of letters!");
            string userText = Console.ReadLine();

            // Jeg bruger userText.Length til at give mig længeden af stringen (userText er brugerns input, og .Length er inbygget)
            Console.WriteLine($"Your word is {userText.Length} letters long");
            Console.ReadLine();
        }
    }
}
