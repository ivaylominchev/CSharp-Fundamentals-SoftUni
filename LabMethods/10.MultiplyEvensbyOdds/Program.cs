using System.Net.Http.Headers;

namespace _10.MultiplyEvensbyOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number=Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int EvenSum = GetSumOfEvenDigits;

            Console.WriteLine(Math.Abs(*GetSumOfOddDigits));
        }
        static void GetMultipleOfEvenAndOdds(int[] number)
        {
            int[] even=new int[number.Length];
            int[] odds = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]==0)
                {
                    even[i] = number[i];
                }
                else
                {
                    odds[i] = number[i];
                }
            }
            
            
        }
        static int GetSumOfEvenDigits(int[] even)
        {
            int sum=0;
            for (int i = 0; i < even.Length; i++)
            {
                sum += even[i];
            }
            return sum;
        }
        static int GetSumOfOddDigits(int[] odds)
        {
            int sum = 0;
            for (int i = 0; i < odds.Length; i++)
            {
                sum += odds[i];
            }
            return sum;
        }
    }
}