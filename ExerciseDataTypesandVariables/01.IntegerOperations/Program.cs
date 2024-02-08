namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            double firstOperation = number1 + number2;
            double secondOperation = (int)firstOperation / number3;
            double thirdOperation = secondOperation*number4;
            Console.WriteLine(thirdOperation);
        }
    }
}