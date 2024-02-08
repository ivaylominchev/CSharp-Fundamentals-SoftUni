using System.Xml.Schema;

namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int student = int.Parse(Console.ReadLine());
            double priceOfLightSaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());
            double totalPrice = 0;
            double freeBelts = student / 6;
            

            totalPrice = priceOfRobe * student + (priceOfBelt * (student - freeBelts)) + priceOfLightSaber * (Math.Ceiling(student + student * 0.1));
            double neededMoney = amountOfMoney - totalPrice;
            if (totalPrice <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else 
            {
                Console.WriteLine($"John will need {Math.Abs(neededMoney):F2}lv more.");
            }
            
            
        }
    }
}