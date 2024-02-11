namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            int number=int.Parse(Console.ReadLine());
            int number1 = int.Parse(Console.ReadLine());
            if (input== "add")
            {
                Add(number,number1);
            }
            else if (input== "multiply")
            {
                Multiply(number,number1);
            }
            else if (input== "subtract")
            {
                Subtract(number,number1);
            }
            else if (input== "divide")
            {
                Divide(number,number1);
            }
            
        }

        private static void Add(int number,int number1)
        {
            int sum=number + number1;
            Console.WriteLine(sum);
        }
        private static void Multiply(int number, int number1)
        {
            int mult = number * number1;
            Console.WriteLine(mult);
        }
        private static void Subtract(int number, int number1)
        {
            int sub = number - number1;
            Console.WriteLine(sub);
        }
        private static void Divide(int number, int number1)
        {
            int div = number / number1;
            Console.WriteLine(div);
        }
    }
}