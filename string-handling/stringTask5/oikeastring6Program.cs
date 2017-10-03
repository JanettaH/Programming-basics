using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("syötä haluamasi teksti");
            string userInput = Console.ReadLine().ToLower();

            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            int total = 0;

            for (int i = 0; i < userInput.Length; i++)
            {

                if (vowels.Contains(userInput[i]))
                {
                    total++;
                }
            }
            Console.WriteLine("syöte sisältää {0} vokaalia", total);
            Console.ReadLine();
        }
    }
}
