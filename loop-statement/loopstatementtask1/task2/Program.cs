using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("syötä luku");
            int userInput = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 1; i <= userInput; i++)
            {
                result = result + i;
            }
            {
                Console.WriteLine("Result {0}", result);
            }
            Console.ReadLine();
            }   
        }   
        }
    }
}
