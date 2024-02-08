namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double volume = 0;
            double newVolume = 0;
            string biggestKeg=string.Empty;
            string model=string.Empty;
            float radius;
            int height;


            for (int i = 0; i < n; i++)
            {
                model = Console.ReadLine();
                radius=float.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                newVolume = Math.PI * Math.Pow(radius,2) * height;

                if (newVolume>volume)
                {
                    volume = newVolume;
                    biggestKeg = model;
                }
                
            }
            Console.WriteLine(biggestKeg);
        }
    }
}