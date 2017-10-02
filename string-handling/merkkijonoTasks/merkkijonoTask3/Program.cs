using System;

namespace merkkijonoTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("syota halumasi syote");
            string userInput = Console.ReadLine().ToString();

            int counter = 0;


            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == System.Convert.ToChar("l"))
                    counter = counter + 1;
            }
            Console.WriteLine("syotteessa on yhteensa {0} L-kirjainta", counter);
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}
