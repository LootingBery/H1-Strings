namespace AddSeparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hardcoded ord og separator fra opgaven
            Console.WriteLine(SeperationTool("ABCD", "^"));
            Console.WriteLine(SeperationTool("chocolate", "-"));
            Console.ReadLine();
        }

        // Skaber vores string med separator mellem hvert tegn
        static string SeperationTool(string input, string separator)
        {
            // Håndterer tomme strenge
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(separator))
            {
                return input; // Returnerer input som det er
            }
            // Konverterer strengen til et array af tegn og joiner dem med separatoren
            char[] characters = input.ToCharArray();
            return string.Join(separator, characters);
        }
    }
}
