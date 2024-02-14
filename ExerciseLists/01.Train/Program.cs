namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons=Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxcapacity=int.Parse(Console.ReadLine());

            string input;
            while ((input=Console.ReadLine())!="end") 
            {
                string[] commands = input.Split();

                if (commands[0]=="Add")
                {
                    wagons.Add(int.Parse(commands[1]));
                }
                else
                {
                    int passengers = int.Parse(commands[0]);
                    for (int i = 0; i < wagons.Count; i++) 
                    {
                        if (passengers +wagons[i]<= maxcapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
