using System.Threading.Channels;

namespace _05._Digits_LettersandOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string digits = string.Empty;
            string letter = string.Empty;
            string symbols = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (char.IsDigit(c))
                {
                    digits += c;  
                }
                else if (char.IsLetter(c))
                {
                    letter += c;
                }
                else
                {
                    symbols += c;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letter);
            Console.WriteLine(symbols);

        }
    }
}
