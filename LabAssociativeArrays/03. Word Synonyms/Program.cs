using System.Diagnostics.CodeAnalysis;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> words= new Dictionary<string, List<string>>(); 
            
            for (int i = 0; i < n; i++) 
            { 
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    List<string> newWords = new List<string>();

                    words.Add(word,newWords);

                }

                List<string> newList = words[word];
                newList.Add(synonym);

            }
            
            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
            }
        }
    }
}
