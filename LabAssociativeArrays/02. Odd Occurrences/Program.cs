namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordToLower=word.ToLower();
                if (!counts.ContainsKey(wordToLower))
                {
                    counts.Add(wordToLower, 0);
                }
                counts[wordToLower]++;
            }
            foreach (var count in counts)
            {
                if (count.Value % 2 !=0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
