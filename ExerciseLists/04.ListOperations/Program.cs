namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list =Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string commands;
            while ((commands=Console.ReadLine()) != "End")
            {
                string[] arguments = commands.Split();

                if (arguments[0] == "Add")
                {
                    list.Add(int.Parse(arguments[1]));
                }
                else if (arguments[0] == "Insert")
                {
                    int number = int.Parse(arguments[1]);
                    int index = int.Parse(arguments[2]);
                    if (index >= list.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.Insert(index, number);
                    }
                }
                else if (arguments[0] == "Remove")
                {
                    int index = int.Parse(arguments[1]);
                    if (index >= list.Count || index < 0 )
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.RemoveAt(index);
                    }
                }
                else if (arguments[1] == "left")
                {
                    int count = int.Parse(arguments[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int firstNumber = list.First();
                        list.Add(firstNumber);
                        list.Remove(firstNumber);
                    }
                }
                else if (arguments[1] == "right")
                {
                    int count = int.Parse(arguments[2]);
                    for(int i = 0; i < count; i++)
                    {
                        int lastNumber = list.Last();
                        list.Remove(lastNumber);
                        list.Insert(0,lastNumber);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
