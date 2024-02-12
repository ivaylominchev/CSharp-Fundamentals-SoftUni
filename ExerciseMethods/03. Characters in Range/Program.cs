namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());

            CharacterInRange(char1, char2);
        }
        static void CharacterInRange(char char1,char char2)
        {
            char def = char1;
            if (char1 > char2)
            {
                char1 = char2;
                char2 = def;
            }
            for (int i = char1+1; i < char2; i++) 
            {
                char symbol = (char)i;
                Console.Write(symbol + " ");
            }
        }

    }
}
