namespace _11.RefactorVolumeofPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length, width, height, V = 0;
            
            length = double.Parse(Console.ReadLine());
            
            width = double.Parse(Console.ReadLine());
            
            height = double.Parse(Console.ReadLine());
            V = (length * width * height) / 3;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {V:f2}");

        }
    }
}