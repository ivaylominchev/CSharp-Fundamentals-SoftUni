namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int p=int.Parse(Console.ReadLine());
            int courses = n/ p;
            int add=n % p;
            if (add<=p && add!=0)
            {
                courses += 1;
            }
            
            Console.WriteLine(courses);
        }
    }
}