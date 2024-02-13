namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            TopNumber(n);
        }
        static void TopNumber(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                string s = i.ToString();
                bool oddNumber = false;
                for (int j = 0; j < s.Length; j++)
                {
                    sum += s[j];
                    if (s[j] % 2 != 0)
                    {
                        oddNumber = true;
                    }

                }
                if (sum % 8 == 0)
                {
                    if (oddNumber)
                    {
                        Console.WriteLine(s);
                    }
                }
                sum = 0;
            }
        }
    }
}
