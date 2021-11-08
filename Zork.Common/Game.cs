using System;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    public class Game
    {
        public static Game Instance { get; private set; }
        public World World { get; private set; }
        [JsonIgnore]
        public Player Player { get; private set; }
        [JsonIgnore]
        private bool IsRunning { get; set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;
        }

        public void Run()
        {
            IsRunning = true;
            Room previousRoom = null;
            while (IsRunning)
            {
                Console.WriteLine(Player.Location);
                if (previousRoom != Player.Location)
                {
                    Console.WriteLine(Player.Location.Description);
                    previousRoom = Player.Location;
                }
                Console.Write(">");
                Commands command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        IsRunning = false;
                        break;
                    case Commands.LOOK:
                        Player.AddMoves();
                        Console.WriteLine(Player.Location.Description);
                        break;
                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = (Directions)command;
                        if(Player.Move(direction) == false)
                        { 
                            Console.WriteLine("The way is shut!");
                            Player.AddMoves();
                        }
                        break;
                    case Commands.SCORE:
                        Player.AddMoves();
                        Console.WriteLine($"Your score is {Player.score} in {Player.moves} move(s).");
                        break;
                    case Commands.REWARD:
                        Player.AddScore();
                        Console.WriteLine("5 Score Obtained.");
                        break;

                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
            }
        }


        public static void StartFromFile(string gamefilename)
        {
            if (!File.Exists(gamefilename))
            {
                throw new FileNotFoundException("Expected file.", gamefilename);
            }
            Start(File.ReadAllText(gamefilename));
        }
        public static void Start(string gameJsonString)
        {
            Console.WriteLine("Welcome to Zork!");
            Instance = Load(gameJsonString);
        }

        public static Game Load(string jsonString)
        {
            Game game = JsonConvert.DeserializeObject<Game>(jsonString);
            game.Player = game.World.SpawnPlayer();

            return game;
        }

        private static Commands ToCommand(string commandString) => (Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN);
    }
}
