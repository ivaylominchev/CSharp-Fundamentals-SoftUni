namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            int[] arr=new int[n];
            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                total += people;
                arr[i] = people;
            }
            Console.WriteLine(String.Join(" ",arr));
            Console.WriteLine(total);
        }
    }
}