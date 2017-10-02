using System;

namespace merkkijonoTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kirjoita haluamasi syote");
            string userInput = Console.ReadLine().ToString();

            Console.WriteLine("syotteessa on {0} merkkia", userInput.Length);
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}