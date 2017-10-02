using System;

namespace merkkijonotask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("syota palindromi");
            string userInput = Console.ReadLine().ToString();

            string userInputPalindrome = "";
            string userInputTrimmed = userInput.Replace(",", "");
            userInputTrimmed = userInputTrimmed.Replace(".", "");
            userInputTrimmed = userInputTrimmed.Replace("?", "");
            userInputTrimmed = userInputTrimmed.Replace("!", "");
            userInputTrimmed = userInputTrimmed.Replace(" ", "");
            userInputTrimmed = userInputTrimmed.Replace("\"", "");
            userInputTrimmed = userInputTrimmed.Replace("\'", "");
            userInputTrimmed = userInputTrimmed.Replace(":", "");
            userInputTrimmed = userInputTrimmed.Replace("-", "");
            userInputTrimmed = userInputTrimmed.ToLower();

            for (int i = 0; i < userInputTrimmed.Length; i++)
            {
                userInputPalindrome = userInputPalindrome + userInputTrimmed[userInputTrimmed.Length - i - 1];
            }
            if (userInputPalindrome == userInputTrimmed)
            {
                Console.WriteLine("imba palindromi!");
            }
            else
            {
                Console.WriteLine("{0}, ei ole palindromi", userInput);
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}
