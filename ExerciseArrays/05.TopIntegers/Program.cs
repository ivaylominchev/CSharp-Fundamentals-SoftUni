﻿namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            
            for (int i = 0; i < arr.Length; i++)
            {
                bool check = true;
                for (int j = i+1; j <arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        check = false;
                        
                    }
                    
                }
                if (check)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}