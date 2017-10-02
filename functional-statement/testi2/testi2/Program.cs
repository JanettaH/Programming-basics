using System;

namespace testi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("syötä luku");
            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int userNumber);
            if (userNumber > 0)
            {
                Console.WriteLine("tässä tähtijonosi {0}", CreateStarString (userNumber));
            }
            else
            {
                Console.WriteLine("numero {0} ei ole sallittu syöte", userNumber);
            }
            Console.WriteLine("press any key to continue");
            Console.ReadLine();
            string CreateStarString (int StarsAsNumber)
            {
                string strStars = "";
                for (int i = 1; i <= StarsAsNumber; i++)
                {
                    strStars = strStars + "*";
                }
                return strStars;
            }
        }
    }
}
