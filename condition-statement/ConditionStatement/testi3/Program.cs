using System;

namespace testi3
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
