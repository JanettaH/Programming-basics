using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA;
            int numberB;
            int numberC;
            
            Console.WriteLine("Anna yksi luku");
            string userInput = Console.ReadLine();
            int.TryParse(userInput, out numberA);

            Console.WriteLine("Anna toinen luku");
            userInput = Console.ReadLine();
            int.TryParse(userInput, out numberB);

            Console.WriteLine("Anna kolmas luku");
            userInput = Console.ReadLine();
            int.TryParse(userInput, out numberC);

            if (numberA > numberB)
            {
                if (numberA > numberC)
                {
                    if (numberB > numberC)
                    {
                        Console.WriteLine("{0}, {1}, {2}", numberC, numberB, numberA); 
                    }
                    else
                    {
                        Console.WriteLine("{0}, {1}, {2}", numberB, numberC, numberA);
                    }
                }
                else
                {
                    if (numberB > numberC)
                    {
                        Console.WriteLine("{0}, {1}, {2}", numberC, numberA, numberB);
                    }
                    else
                    {
                        Console.WriteLine("{0}, {1}, {2}", numberB, numberA, numberC);
                    }
                }
            } else
            {
               if (numberA < numberC)
                {
                    if (numberB < numberC)
                    {
                        Console.WriteLine("{0}, {1}, {2}", numberA, numberB, numberC);
                    }
                    else
                    {
                        Console.WriteLine("{0}, {1}, {2}", numberA, numberC, numberB);
                    }
                }
                else
                {
                    if (numberB > numberC)
                    {
                        Console.WriteLine("{0}, {1}, {2}", numberC, numberA, numberB);
                    }
                    else
                    {
                        Console.WriteLine("{0}, {1}, {2}", numberB, numberA, numberC);
                    }
                }
            }
                Console.ReadKey();

        }
    }
}
