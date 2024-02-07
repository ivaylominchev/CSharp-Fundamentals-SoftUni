namespace _10.LowerorUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch=char.Parse(Console.ReadLine());
            
            if (ch>='a'&& ch<='z')
            {
                Console.WriteLine("lower-case");
            }
            else if (ch>='A'&& ch<='Z')
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}