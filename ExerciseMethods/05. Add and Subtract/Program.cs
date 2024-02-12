namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Subtract(a,b,c));
            
        }

        static int SumOfIntegers(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
       static int Subtract(int a, int b, int c) 
        {
            int result = SumOfIntegers(a, b) - c;
            return result; 
        }

    }
}
