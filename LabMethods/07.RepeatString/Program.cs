﻿namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            int n=int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(input, n));
        }
        static string RepeatString(string input, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += input;
            }
            return result;
        }

    }
}