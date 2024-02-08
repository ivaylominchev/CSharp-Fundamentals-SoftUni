namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount=int.Parse(Console.ReadLine());
            double headserPrice=double.Parse(Console.ReadLine());
            double mousePrice=double.Parse(Console.ReadLine());
            double keyboardPrice=double.Parse(Console.ReadLine());
            double displayPrice=double.Parse(Console.ReadLine());

            double money = headserPrice * (lostGamesCount / 2);
            money += mousePrice * (lostGamesCount / 3);
            money += keyboardPrice * (lostGamesCount / 6);
            money +=displayPrice * (lostGamesCount / 12);

            Console.WriteLine($"Rage expenses: {money:F2} lv.");
        }
    }
}