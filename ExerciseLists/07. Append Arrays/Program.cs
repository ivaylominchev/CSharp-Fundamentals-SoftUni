using System;
using System.Net.Security;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> newArray = new List<string>();
            
            for (int i = array.Count - 1; i >= 0; i--)
            {
                List<string> symbols = array[i]
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                newArray.AddRange(symbols);
            }

            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}
