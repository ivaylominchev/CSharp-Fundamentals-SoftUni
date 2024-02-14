namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guestList=int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < guestList; i++)
            {
                string[] arguments =Console.ReadLine().Split();
                string name = arguments[0];
                if (arguments[2]=="going!")
                {
                    if (list.Exists(e => e == name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        list.Add(name);
                    }
                }
                else if (arguments[2] == "not")
                {
                    if (list.Exists(x => x == name))
                    {
                        list.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
               
            }
            Console.WriteLine(string.Join("\n",list));
        }
    }
}
