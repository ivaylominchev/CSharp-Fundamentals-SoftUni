namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(a, x));
        }

        static double RaiseToPower(double a, int x)
        {
            double result = 0d;
            result = Math.Pow(a, x);
            return result;
        }
    }
}