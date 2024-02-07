namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lastDigit = 0;
            int number = 0;
            int sumOfDigits = 0;
            bool trueOrFalse = true;
            for (int i = 1; i <= n; i++)
            {
                number = i;
                while (number != 0)
                {
                    lastDigit = number % 10;
                    sumOfDigits += lastDigit;
                    number = number / 10;
                }
                trueOrFalse = ( sumOfDigits == 5) || ( sumOfDigits== 7) || (sumOfDigits == 11);
                Console.WriteLine($"{i} -> {trueOrFalse}");
                sumOfDigits= 0;
                
            }

        }
    }
}