using static System.Net.Mime.MediaTypeNames;

namespace OverloadedMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = Prompt("Hi Class!", ConsoleColor.DarkMagenta);
            Console.WriteLine(output);
        }
        static string Prompt(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }
        static string Prompt(string text, ConsoleColor color)
        {
            Console.Write(text);
            Console.ForegroundColor = color;
            return Console.ReadLine();
        }
    }
}
