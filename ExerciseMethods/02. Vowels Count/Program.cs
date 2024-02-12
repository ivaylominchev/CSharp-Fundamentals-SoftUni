namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            int vowelCount = VowelCount(sentence);

            Console.WriteLine(vowelCount);
        }
        static int VowelCount(string sentence)
        {
            int count = 0;
            sentence = sentence.ToLower();
            
            foreach (var symbol in sentence)
            {
                if (symbol == 'e'
                    || symbol == 'a'
                    || symbol == 'o'
                    || symbol == 'i'
                    || symbol == 'u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
