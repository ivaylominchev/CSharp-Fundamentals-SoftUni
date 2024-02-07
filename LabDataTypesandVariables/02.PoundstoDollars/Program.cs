namespace _02.PoundstoDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double britishPounds = double.Parse(Console.ReadLine());
            double usDollars = britishPounds * 1.31;
            Console.WriteLine($"{usDollars:F3}");
        }
    }
}