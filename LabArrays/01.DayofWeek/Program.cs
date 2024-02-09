namespace _01.DayofWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
            int number = int.Parse(Console.ReadLine());
            
            switch (number)
            {
                case 1:
                    Console.Write(arr[0]);
                    break;
                case 2:
                    Console.Write(arr[1]);
                    break;
                case 3:
                    Console.Write(arr[2]);
                    break;
                case 4:
                    Console.Write(arr[3]);
                    break;
                case 5:
                    Console.Write(arr[4]);
                    break;
                case 6:
                    Console.Write(arr[5]);
                    break;
                case 7:
                    Console.Write(arr[6]);
                    break;
                default:
                    Console.Write("Invalid day!");
                    break;
            }
        }
    }
}