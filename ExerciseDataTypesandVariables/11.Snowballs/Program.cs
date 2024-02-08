using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger snowballValue = 0;
            BigInteger highestSnowball = 0;
            int newSnowballSnow = 0;
            int newSnowballTime = 0;
            int newSnowballQuality = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue > highestSnowball)
                {
                    highestSnowball = snowballValue;
                    newSnowballSnow = snowballSnow;
                    newSnowballTime = snowballTime;
                    newSnowballQuality = snowballQuality;


                }
            }
            Console.WriteLine($"{newSnowballSnow} : {newSnowballTime} = {highestSnowball} ({newSnowballQuality})");
        }
    }
}