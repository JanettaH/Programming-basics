using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("syota haluamasi syote");
            string userInput = Console.ReadLine().ToString();
            Console.WriteLine(userInput.Replace("e", "@"));

            Console.WriteLine("press any key to continue");
            Console.ReadLine();
        }
    }
}
