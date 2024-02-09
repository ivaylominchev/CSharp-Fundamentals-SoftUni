namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] arr = Console.ReadLine().Split(" ")
                .Select(double.Parse)
                .ToArray();
            int[] roundNumbers = new int[arr.Length];

            for (int i = 0; i <arr.Length ; i++)
            {
                roundNumbers[i] = (int)Math
                    .Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{arr[i]} => {roundNumbers[i]}");
            }
        }
    }
}