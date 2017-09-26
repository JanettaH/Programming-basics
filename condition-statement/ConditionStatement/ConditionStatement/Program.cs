using System;

namespace ConditionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla.");
            Console.Write("Syötä Luku: ");
            string userInput = Console.ReadLine();
            // int number = int.Parse(userInput);
            bool isNumber = int.TryParse(userInput, out int number);

            if (isNumber == true)
            {
                if (number > 0)
                {
                    Console.WriteLine($"Numero {number} on positiivinen");
                }
                else if (number < 0)
                {
                    Console.WriteLine($"Numero {number} on negatiivinen");
                }
                else
                {
                    Console.WriteLine("Numero 0 on nolla.");
                }
            }
            else
            {
                Console.WriteLine("Vääräsyöte");
            }
            Console.ReadKey();

        }
    }
}
