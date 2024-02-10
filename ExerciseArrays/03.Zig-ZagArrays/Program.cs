namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            bool isFisrArratSelected=true;
            string[] first=new string[n];
            string[] second = new string[n];
            for (int i = 0; i < n; i++)
            {
                string numbers=Console.ReadLine();
                string[] arrayNumbers = numbers.Split();
                if (isFisrArratSelected)
                {
                    first[i] = arrayNumbers[0];
                    second[i] = arrayNumbers[1];
                }
                else
                {
                    first[i] = arrayNumbers[1];
                    second[i] = arrayNumbers[0];
                }
                isFisrArratSelected = !isFisrArratSelected;
            }
            Console.WriteLine(string.Join(" ", first));
            Console.WriteLine(string.Join(" ", second));
        }
    }
}