using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ikä");
            string userInput = Console.ReadLine();

            int.TryParse(userInput, out int age);

            Console.WriteLine("Oletko mtk-jäsen? K/E");
            string mtkMember = Console.ReadLine();

            Console.WriteLine("Oletko opiskelija? K/E");
            string student = Console.ReadLine();

            Console.WriteLine("Oletko varusmies? K/E");
            string varusmies = Console.ReadLine();

            double discountprocent = 0;

            if (age < 7)
            {
                discountprocent = 1;
            }
            else
            {
                if (age > 7 && age < 15)
                {
                    discountprocent = 0.5;

                }
                else if (age >= 65)
                    {
                        discountprocent = 0.5;
                    }
                else
                {
                    if (mtkMember == "K")
                    {
                        discountprocent = 0.15;
                    }
                    if (student == "K")
                    {
                        if (mtkMember == "K")
                        {
                            discountprocent = 0.15 + 0.45;
                        }
                        else
                        {
                            discountprocent = 0.45;
                        }
                    }
                    if (varusmies == "K")
                    {
                        discountprocent = 0.5;
                    }
                }
            }
            double price = 16 * (1 - discountprocent);

            Console.WriteLine("Lipun hinta {0}", price);

            Console.ReadKey();
        }
    }
}
