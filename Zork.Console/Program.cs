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
            
            ConsoleInputService input = new ConsoleInputService();
            ConsoleOutputService output = new ConsoleOutputService();

            Game.StartFromFile(gameFilename, input, output);

            while (Game.Instance.IsRunning)
            {
                output.WriteLine($"{Game.Instance.Player.Location}\n{Game.Instance.Player.Location.Description}");
                output.Write("\n> ");
                input.GetInput();
            }
            output.WriteLine("Thanks for playing!");
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}
