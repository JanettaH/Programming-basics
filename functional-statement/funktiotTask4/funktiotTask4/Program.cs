using System;

namespace funktiotTask4
{
    class Program
    {
        static void Main(string[] args)
        {

            int maxInteger = 0;
            int maxIntegerPosition = 0;



            maxInteger = MaxOfTen(out string strNumbers, out maxIntegerPosition);

            Console.WriteLine("\nsyottamasi lukusarja oli {0}", strNumbers);
            Console.WriteLine("\nsuurin syottamasi luku {0} oli {1}. lukusarjassa", maxInteger, maxIntegerPosition);

            Console.WriteLine("press any key to continue");
            Console.ReadLine();
        }

        static int MaxOfTen(out string numberToPrint, out int maxIntegerPositionPrint)
        {
            int number = 0, maxIntegerToPrint = 0;
            numberToPrint = String.Empty;
            //string numbersToPrint = "";
            maxIntegerPositionPrint = 0;

            Console.WriteLine("syota kymmenen lukua");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0}. ", i);

                string userInput = Console.ReadLine();

                while ((!int.TryParse(userInput, out number)) || (number < 0))
                {
                    Console.WriteLine("vaara syote, syota positiivinen luku!");
                    Console.Write("{0}.", i);

                    userInput = Console.ReadLine();
                }

                if (i > 1)
                    numberToPrint = numberToPrint + " " + number;
                else
                    numberToPrint = numberToPrint + " " + number;

                if (maxIntegerToPrint < number)
                {
                    maxIntegerToPrint = number;
                    maxIntegerPositionPrint = i;
                }
            }
            return maxIntegerToPrint;
        }
    }
}