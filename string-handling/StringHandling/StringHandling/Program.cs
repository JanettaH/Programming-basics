using System;

namespace StringHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Heippa");

            // string tyyppinen muuttuja, joka on tekstiä = merkkijono
            string text = "Moi";

            // int tyyppinen muuttuja, joka on kokonaisluku
            int firstNumber = 2;
            int secondNumber = 5;
            int sum = firstNumber + secondNumber;

            Console.WriteLine(sum + " " + text);

            // Kutsutaan text-muuttujan ToUpper()-metodia
            Console.WriteLine(text.ToUpper());

            // For-silmukka
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("For-loop, kierros " + i);
            }


            // string userInput = Console.ReadLine();
            // Console.WriteLine(userInput);

            text = "Hello World!";
            Console.WriteLine($"{text} lauseessa on {text.Length} merkkiä.");
            Console.WriteLine("{0} lauseessa on {1} merkkiä.", text, text.Length);

            Console.ReadLine();
        }
    }
}





            