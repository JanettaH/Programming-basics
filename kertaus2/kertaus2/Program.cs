using System;

namespace kertaus2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("syötä luku");

            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out int number);

            if (isNumber == true)
            {
                if (number > 0)
                {
                    Console.WriteLine("numero {0} on positiivinen", number);
                }
                else if (number < 0)
                {
                    Console.WriteLine("numero {0} on negatiivinen", number);
                }
                else
                {
                    Console.WriteLine("luku {0} on nolla", number);
                }
            }
            else
            {
                Console.WriteLine("syöte ei ole luku");
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}
