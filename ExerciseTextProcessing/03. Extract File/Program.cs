using System.Reflection.Metadata;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            string fileName = string.Empty;
            string extension = string.Empty;

            int fileNameIndex = path.LastIndexOf("\\");
            int extensionIndex = path.LastIndexOf(".");

            fileName = path.Substring(fileNameIndex + 1,extensionIndex-fileNameIndex - 1);
            extension = path.Substring(extensionIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
