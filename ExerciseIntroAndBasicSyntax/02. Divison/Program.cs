namespace _2._Divison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            int maxdel = 0;
            if (number%2==0)
            {
                maxdel = 2;
            }
            if (number % 3 == 0)
            {
                maxdel = 3;
            }
            if (number % 6 == 0)
            {
                
                maxdel = 6;
            }
            if (number % 7 == 0)
            {
                maxdel = 7;
            }
            if (number % 10 == 0)
            {
                maxdel = 10;

            }
         
            if (maxdel==0)
            {
                Console.WriteLine("Not divisible");
               
            }
            else
            {
                Console.WriteLine($"The number is divisible by {maxdel}");
            }
        }
    }
}