﻿namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int evenSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    evenSum+=arr[i];
                }
            }
            Console.WriteLine(evenSum);
        }
    }
}