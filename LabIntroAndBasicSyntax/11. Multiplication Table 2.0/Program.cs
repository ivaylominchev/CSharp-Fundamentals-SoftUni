using System.Xml;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int mult=int.Parse(Console.ReadLine());
            
            for (int i = mult; i <=10; i++)
            {

                int product = n * i;
                
                Console.WriteLine($"{n} X {i} = {product}");
            }
            if (mult > 10)
            {
                int newNumber= n * mult;
                Console.WriteLine($"{n} X {mult} = {newNumber} ");
            }

        }
    }
}