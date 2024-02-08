namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int newYield = 0;
            int dayCount = 0;
            int totalAmount=0;  
            

            while (startingYield>=100)
            {
                newYield = startingYield-26;
                totalAmount+=newYield;
                startingYield -= 10;
                dayCount++;
            }
            if (startingYield<100)
            {
                if (totalAmount>=26)
                {
                    totalAmount -= 26;
                }
                else
                {
                    totalAmount -= totalAmount;
                }
                
            }
            Console.WriteLine(dayCount);
            Console.WriteLine(totalAmount);
        }
    }
}