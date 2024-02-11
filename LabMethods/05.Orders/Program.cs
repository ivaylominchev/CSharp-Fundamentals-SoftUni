namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;
            price = TotalPrice(input, quantity, price);
            Console.WriteLine($"{price:f2}");
        }

        private static double TotalPrice(string input, int quantity, double price)
        {
            if (input == "coffee")
            {
                price = quantity * 1.5;
                /*Console.WriteLine($"{price:f2}");*/
            }
            else if (input == "water")
            {
                price = quantity * 1;
                /*Console.WriteLine($"{price:f2}");*/
            }
            else if (input == "coke")
            {
                price = quantity * 1.40;
                /*Console.WriteLine($"{price:f2}");*/
            }
            else if (input == "snacks")
            {
                price = quantity * 2;
                /*Console.WriteLine($"{price:f2}");*/
            }

            return price;
        }
    }
}