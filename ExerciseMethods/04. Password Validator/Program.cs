using System.Xml.Serialization;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();

            bool characterCheck = CharactersValidator(input);
            bool symbolCheck = LettersAndDigits(input);
            bool digitCheck = DigitsValidator(input);

            if (!characterCheck)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!symbolCheck)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!digitCheck)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (characterCheck && symbolCheck && digitCheck)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool LettersAndDigits(string input) 
        {
            foreach (var symbol in input) 
            {
                if (symbol >= 65 && symbol <= 90 ||
                    symbol >= 97 && symbol <= 122 ||
                    symbol >= 48 && symbol <= 57)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        static bool CharactersValidator(string input)
        {
            if (input.Length < 6 || input.Length > 10)
            {
                return false;
            }
            return true;
        }
        static bool DigitsValidator(string input) 
        {
            int digitCounter = 0;
            
            foreach (var symbol in input)
            {
                if (symbol >= 48 && symbol <= 57)
                {
                    digitCounter++;
                }
            }
            if (digitCounter < 2)
            {
                return false;
            }
            return true;
        }
    }
}
