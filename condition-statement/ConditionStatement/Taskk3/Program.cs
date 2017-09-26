using System;

namespace ConditionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen, nolla");
            Console.Write("Syötä Luku: ");
            string userInput = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(userInput, out number);

            if (isNumber == true)
            {
                if (number > 0)
                {
                    Console.WriteLine($"Numero {number} on positiivinen");
                }
                else if (number < 0)
                {
                    Console.WriteLine($"Numero {number} on negatiivinen");
                } else 
                {
                    Console.WriteLine($"Numero {number} on nolla");
                }
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                isNumber = int.TryParse(userInput, out number);

                if (number % 2 == 0)
                    Console.WriteLine($"Numero {number} on parillinen");
                else
                    Console.WriteLine($"Numero {number} on pariton");
            }
            Console.ReadKey();
        }
    }
}