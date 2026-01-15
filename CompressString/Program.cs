using System;

namespace CompressString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CompressString("kkkktttrrrrrrrrrr"));
            Console.WriteLine(CompressString("p555ppp7www"));
            Console.ReadLine();

            static string CompressString(string input)
            {
                // Sætter værdigere
                string result = "";
                char currentChar = input[0];
                int amount = 1;

                // for loop der tilføjere det antal bogstavere der er ved siden af hinanden
                for (int i = 1; i < input.Length; i++)
                {
                    if (input[i] == currentChar)
                    {
                        amount++;
                    }
                    else
                    {
                        result = result + currentChar + amount;
                        currentChar = input[i];
                        amount = 1;
                    }
                }
                // Skal fremvise vores resultat
                result = result + currentChar + amount;
                return result;
            }
        }
    }
 }