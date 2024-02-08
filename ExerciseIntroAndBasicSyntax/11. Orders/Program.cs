namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N=int.Parse(Console.ReadLine());
            double price=0;
            double totalPrice=0;

            for (int i = 1; i <=N; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days=int.Parse(Console.ReadLine());
                int capsulesCount=int.Parse(Console.ReadLine());
                price = ((days * capsulesCount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${price:F2}");

                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}