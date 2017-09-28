using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("syötä luku");
            string userInput = Console.ReadLine();

            // IF 0
            bool isNumber = int.TryParse(userInput, out int number);

            if (isNumber == true)
            {
                if (number == 0)
                {
                    Console.WriteLine("1");
                }
                else if (number < 0)
                {
                    int result = 0;
                    int result2 = 0;

                    for (int i = -1; i >= number; i--)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine("Index {0} : userInput{1} : condition {2}", i, number, i >= number);
                            result = result + i;
                        }
                        if (i % 2 == 0)
                        {
                            Console.WriteLine("Index {0} : userInput{1} : condition {2}", i, number, i >= number);
                            result2 = result2 + i;
                        }
                    }
                    Console.WriteLine("Result {0}", result);
                    Console.WriteLine("Result2 {0}", result2);
                }
                else
                {
                    int result = 0;
                    int result2 = 0;

                    for (int i = 1; i <= number; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine("Index {0} : userInput{1} : condition {2}", i, number, i < number);
                            result = result + i;
                        }
                        if (i % 2 == 0)
                        {
                            Console.WriteLine("Index {0} : userInput{1} : condition {2}", i, number, i < number);
                            result2 = result2 + i;
                        }
                    }
                    Console.WriteLine("Result {0}", result);
                    Console.WriteLine("Result2 {0}", result2);
                }
            }
            else
            {
                Console.WriteLine("Mistake");
            }
            Console.ReadKey();
        }
    }
}
