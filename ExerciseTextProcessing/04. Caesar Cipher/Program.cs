﻿using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder encrypted = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char original = text[i];
                encrypted.Append((char)(original + 3));
            }

            Console.WriteLine(encrypted);
        }
    }
}
