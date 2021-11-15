using System;
using System.IO;

namespace Zork
{
    internal class Program
    {

        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);
            
            ConsoleOutputService output = new ConsoleOutputService();
            Game.StartFromFile(gameFilename, output);
            Console.WriteLine("Thanks for playing!");
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}
