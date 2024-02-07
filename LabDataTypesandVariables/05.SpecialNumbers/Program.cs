using System.Security.Cryptography;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int sumOfLastDigit = 0;
            int sum = 0;
            int number=0;
            for (int i = 1; i <= n; i++)
            {
                number = i;
                while (number!=0)
                {
                    sumOfLastDigit = number % 10;
                    sum += sumOfLastDigit;
                    number = number / 10;
                }
                
                if (sum==5 || sum==7 || sum==11 )
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                sum = 0;
            }
        }
    }
}