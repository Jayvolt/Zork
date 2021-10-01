using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    internal class Program
    {
        public static Room CurrentRoom
        {
            get
            {
                return Rooms[Location.Row, Location.Column];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");
            InitializeRooms("Rooms.json");

            Room previousRoom = null;
            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.WriteLine(CurrentRoom);
                if (previousRoom != CurrentRoom)
                {
                    Console.WriteLine(CurrentRoom.Description);
                    previousRoom = CurrentRoom;
                }
                Console.Write(">");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing the game!";
                        break;
                    case Commands.LOOK:
                        outputString = CurrentRoom.Description;
                        break;
                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = Move(command) ? $"You moved {command}" : "The way is shut!";
                        break;

                    default:
                        outputString = "Unknown command.";
                        break;
                }

                Console.WriteLine(outputString);
            }
            Console.WriteLine("Finished");
        }

        private static Commands ToCommand(string commandString) => (Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN);

        private static Room[,] Rooms;

        private static void InitializeRooms(string roomsFilename)
        {
            Rooms = JsonConvert.DeserializeObject<Room[,]>(File.ReadAllText(roomsFilename));
        }

        private static readonly List<Commands> Directions = new List<Commands>
        {
            Commands.NORTH,
            Commands.SOUTH,
            Commands.EAST,
            Commands.WEST
        };

        private static bool IsDirection(Commands command) => Directions.Contains(command);
        private static (int Row, int Column) Location = (1, 1);

        private static bool Move(Commands command)
        {
            Assert.IsTrue(IsDirection(command), "Invalid direction.");

            bool isValidMove = false;

            switch (command)
            {
                case Commands.NORTH when Location.Row < Rooms.GetLength(0) - 1:
                    Location.Row++;
                    isValidMove = true;
                    break;
                case Commands.SOUTH when Location.Row > 0:
                    Location.Row--;
                    isValidMove = true;
                    break;

                case Commands.EAST when Location.Column < Rooms.GetLength(1) - 1:
                    Location.Column++;
                    isValidMove = true;
                    break;
                case Commands.WEST when Location.Column > 0:
                    Location.Column--;
                    isValidMove = true;
                    break;
            }
            return isValidMove;
        }
    }
}
