namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(Print(word));

        }
        static string Print(string word)
        {
            
            string middleChar = string.Empty;
            int length = word.Length / 2;
            if (word.Length % 2 == 0)
            {
                
                middleChar += word[length - 1];
                middleChar += word[length];
            }
            else
            {
                middleChar += word[length];
            }
            return middleChar;
        }
    }
}

/*namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            MiddleCharacters(word);
        }

        static void MiddleCharacters(string characters)
        {
            int length = characters.Length;
            if (length % 2 == 0)
            {
                for (int i = 0; i <= length / 2; i++)
                {
                    if (i == length / 2)
                    {
                        Console.WriteLine($"{characters[i - 1]}{characters[i]}");
                    }
                }
            }
            else if (length % 2 != 0)
            {
                for (int i = 0; i <= length / 2; i++)
                {
                    if (i == length / 2)
                    {
                        Console.WriteLine(characters[i]);
                    }
                }
            }
        }
    }
}*/
