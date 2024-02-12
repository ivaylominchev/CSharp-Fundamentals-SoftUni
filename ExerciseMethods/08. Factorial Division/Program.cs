namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            FactorialDivision(a, b);
        }
        static void FactorialDivision(double a, double b)
        {
            double firstFactoriel = 1;
            double secondFactoriel = 1;
            double result = 0;
            for (int i = 1; i <= a; i++)
            {
                firstFactoriel *= i;
            }
            for (int i = 1; i <= b; i++)
            {
                secondFactoriel *= i;
            }
            result = firstFactoriel / secondFactoriel;
            Console.WriteLine($"{result:F2}");
        }
    }
}
