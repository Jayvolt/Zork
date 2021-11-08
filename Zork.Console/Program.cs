using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    internal class Program
    {

        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);
            
            Game.StartFromFile(gameFilename);
            Console.WriteLine("Thanks for playing!");
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}
