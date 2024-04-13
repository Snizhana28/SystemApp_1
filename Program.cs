using System.Diagnostics;

namespace SystemApp_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Start the Calculator");
                Console.WriteLine("2. Start Paint");
                Console.WriteLine("3. Start Notepad");
                Console.WriteLine("0. Exit the program");
                Console.Write("Enter the number of the program you want to start: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Calculator is starting...");
                        Process.Start("calc.exe");
                        break;
                    case "2":
                        Console.WriteLine("Paint is starting...");
                        Process.Start("mspaint.exe");
                        break;
                    case "3":
                        Console.WriteLine("Notepad is starting...");
                        Process.Start("notepad.exe");
                        break;
                    case "0":
                        Console.WriteLine("Exiting the program...");
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }
    }
}
