using System.Diagnostics.Contracts;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToList();

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

        }
    }
}
//2 nachin
/*Console.ReadLine()
    .Split()
    .Where(x => x.Length % 2 == 0)
    .ToList()
    .ForEach(Console.WriteLine);*/