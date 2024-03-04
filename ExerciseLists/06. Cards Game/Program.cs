namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            while (first.Count != 0 && second.Count != 0)
            {
                int firstNumber = first.First();
                int secondNumber = second.First();

                if (firstNumber > secondNumber)
                {
                    first.Add(firstNumber);
                    first.Add(secondNumber);
                    first.Remove(firstNumber);
                    second.Remove(secondNumber);
                    
                }
                else if (firstNumber < secondNumber)
                {
                    second.Add(secondNumber);
                    second.Add(firstNumber);
                    first.Remove(firstNumber);
                    second.Remove(secondNumber);
                    
                }
                else if (firstNumber == secondNumber)
                {
                    first.Remove(firstNumber);
                    second.Remove(secondNumber);
                }
            }
            
            if (second.Count == 0)
            {
                foreach (var numbers in first)
                {
                    sum += numbers;
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else if (first.Count == 0)
            { 
                foreach(var numbers in second)
                {
                    sum += numbers;
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
