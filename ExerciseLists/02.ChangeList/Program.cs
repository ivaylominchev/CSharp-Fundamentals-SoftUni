namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input;
            while ((input=Console.ReadLine())!="end") 
            {
                string[] command = input.Split();
                if (command[0] == "Delete")
                {
                    int number = int.Parse(command[1]);
                    list.RemoveAll(x => x == number);
                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    list.Insert(index, element);
                }           

            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
