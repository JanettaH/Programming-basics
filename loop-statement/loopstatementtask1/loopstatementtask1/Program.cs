﻿using System;

namespace loopstatementtask1
{
    class Program
    {
        static void Main()
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
                    Console.WriteLine("Määrittelemätön");
                }
                else
                {
                    int result = 1;

                    for (int i = 1; i <= number; i++)
                    {
                        Console.WriteLine("Index {0} : userInput{1} : condition {2}", i, number, i < number);
                        result = result * i;
                    }
                    Console.WriteLine("Result {0}", result);
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
