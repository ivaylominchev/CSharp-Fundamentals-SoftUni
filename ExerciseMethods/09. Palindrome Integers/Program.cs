namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            while (number != "END")
            {
                PalindromeIntegerCheck(number);
                
                number = Console.ReadLine();
            }
        }
        static void PalindromeIntegerCheck(string number)
        {
            string result ="true";
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != number[number.Length - 1 - i])
                {
                    result = "false";
                }
            }
            Console.WriteLine(result);
        }

    }
}
