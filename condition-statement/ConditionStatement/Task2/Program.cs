using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa parittoman tai parillisen");
            Console.Write("Syötä Luku: ");
            string userInput = Console.ReadLine();
            // int number = int.Parse(userInput);
            bool isNumber = int.TryParse(userInput, out int number);

            if (isNumber == true)
            {
                if (number % 2 == 0)
                    Console.WriteLine($"Numero {number} on parillinen");
                else
                    Console.WriteLine($"Numero {number} on pariton");
            }
            else
                Console.WriteLine("Vääräsyöte");
            Console.ReadKey();

        }
    }
}
