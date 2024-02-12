namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintMatrix(n);
        }

        static void PrintMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine(n + " ");
            }
        }
    }
}

/*namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Matrix(n);
        }

        static void Matrix(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
        }
    }
}*/
