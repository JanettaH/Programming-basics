using System;

namespace ConditionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla.");
            Console.Write("Syötä Luku: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
        }
    }
}
