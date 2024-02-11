namespace _09.GreaterofTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string inpu1=Console.ReadLine();
            string input2=Console.ReadLine();

        }
        static void GetMax(char input1, char input2)
        {
            char result = input1;
            if (input1 > input2)
            {
                result = input1;
            }
            else
            {
                result = input2;
            }
        }
        static void GetMax(int input1, int input2)
        {

            int result = 0;
            if (input1>input2)
            {
                result = input1;
            }
            else
            {
                result=input2;
            }
        }
        
        static void GetMax(string input1,string input2)
        {
            string result = string.Empty;
            if ((int)input1 > (int)input2)
            {
                result = input1;
            }
            else
            {
                result = input2;
            }
        }
    }
}