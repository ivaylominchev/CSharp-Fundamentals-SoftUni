namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int waterTank = 255;
            int liters;
            int sumOfLiters=0;
            for (int i = 0; i < n; i++)
            {
                liters = int.Parse(Console.ReadLine());
                waterTank-=liters;
                if (waterTank < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                    waterTank+=liters;
                }
                else
                {
                    sumOfLiters += liters;
                }
                 

            }
            Console.WriteLine(sumOfLiters);
        }
    }
}