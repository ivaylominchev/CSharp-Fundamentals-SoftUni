using System.Data.Common;
using System.Security.Cryptography;

namespace _6._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfDigits=0;
            int myNumber = number;
            int fact = 1;
            int lastDigit;
          

            while (number!=0)
            {
                lastDigit = number % 10;
                
                for (int i = 1; i <= lastDigit; i++)
                {
                    fact *= i;
                }

                sumOfDigits += fact;
                number = number / 10;
                fact = 1;
                
            }
            if (sumOfDigits == myNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}