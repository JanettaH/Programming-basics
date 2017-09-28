using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("syötä luku");
            string userInput = Console.ReadLine();

            bool isNumber = int.TryParse(userInput, out int number);

            for (int i = 1; i >= number; i++)



            double result = Math.Sqrt(3);

            Console.WriteLine($"result {result}");

            Console.ReadKey();
        }
    }
}
