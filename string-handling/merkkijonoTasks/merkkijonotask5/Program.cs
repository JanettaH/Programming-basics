using System;

namespace merkkijonotask5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("syota haluamasi teksti");
            //string userInput = Console.ReadLine().ToString();

            //Regex rx = new Regex(@"[AEIOUaeiou]");

            //MatchCollection matches = rx.Matches(userInput);

            //Console.WriteLine("syotteessa on yhteensa {0} vokaalia", matches.Count);
            //Console.WriteLine("press any key to continue");
            //Console.ReadKey();

            // Prompt user for input
            Console.WriteLine("Kirjoita jotain kivaa. Lasketaan siita vokaalit:");

            // Store user input into a variable
            string userInput = Console.ReadLine().ToString();

            // Create a new instance of the Regex class with a regular expression matching all the vowels
            Regex rx = new Regex(@"[AEIOUaeiou]");

            // Store matches between the user input and the regular expression
            MatchCollection matches = rx.Matches(userInput);

            // Print out the number of vowel occurrences in the user input 
            Console.WriteLine("\nSyotteesi sisaltaa {0} vokaalia", matches.Count);

            // Wait for any key to be pressed before exiting
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
