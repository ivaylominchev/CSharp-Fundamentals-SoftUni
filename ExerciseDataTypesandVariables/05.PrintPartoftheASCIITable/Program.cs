namespace _05.PrintPartoftheASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start=int.Parse(Console.ReadLine());
            int end=int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                char c = (char)i;
               /* char n=Convert.ToChar(i);*/

                Console.Write($"{n} ");
            }
        }
    }
}