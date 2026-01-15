namespace IsPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PalindromeChecker("eye"));
            Console.WriteLine(PalindromeChecker("home"));
            Console.ReadLine();
        }

        static bool PalindromeChecker(string str)
        {
            string reversed = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            if (reversed == str)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
