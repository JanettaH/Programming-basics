using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double userDefinedNumber = 0;
            double inputMinNumber = 1;
            double inputMaxNumber = 100;

            userDefinedNumber = AskForANumber(inputMinNumber, inputMaxNumber);

            Console.WriteLine("antamasi luku {0}", userDefinedNumber);

            Console.WriteLine("press any key to continua");
            Console.ReadLine();

            double AskForANumber(double minNumber, double maxNumber)
            {
                double number = 0;

                Console.WriteLine("anna luku, joka on väliltä {0}, {1}", minNumber, maxNumber);

                string userInput = Console.ReadLine();
                while ((!double.TryParse(userInput, out number)) || (number < minNumber) || (number > maxNumber))
                {
                    Console.Clear();
                    Console.WriteLine("{0} ei ole väliltä {1} ja {2} pystyt parempaan", userInput, minNumber, maxNumber);
                    Console.WriteLine("anna luku valilta {0}, {1}", minNumber, maxNumber);
                    userInput = Console.ReadLine();
                }
                return number;
            }
        }
    }
}
