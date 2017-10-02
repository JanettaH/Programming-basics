using System;

namespace testi1
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
                Console.WriteLine("tässä tähtijonosi: {0}", CreateStarString(userNumber));
            }
            else
            {
                Console.WriteLine("mero {0} eiole sallittu", userNumber);
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            string CreateStarString(int StarsAsNumber)
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
