using System;
using System.IO;
using Newtonsoft.Json;
using Zork.Common;

namespace Zork
{
    public class Game
    {
        public static Game Instance { get; private set; }
        public string WelcomeMessage { get; set; }
        public World World { get; private set; }
        [JsonIgnore]
        public Player Player { get; private set; }
        [JsonIgnore]
        public bool IsRunning { get; private set; }
        [JsonIgnore]
        public IInputService Input { get; private set; }
        public IOutputService Output { get; private set; }
        public Game(World world, Player player)
        {
            World = world;
            Player = player;
        }

        public static void StartFromFile(string gamefilename, IInputService input, IOutputService output)
        {
            if (!File.Exists(gamefilename))
            {
                throw new FileNotFoundException("Expected file.", gamefilename);
            }
            Start(File.ReadAllText(gamefilename), input, output);
        }
        public static void Start(string gameJsonString, IInputService input, IOutputService output)
        {
            Instance = Load(gameJsonString);
            Instance.Input = input;
            Instance.Output = output;
            Instance.DisplayWelcomeMessage();
            Instance.IsRunning = true;
            Instance.Input.InputReceived += Instance.InputReceivedHandler;
        }

        private void InputReceivedHandler(object sender, string inputString)
        {
            Room previousRoom = Player.Location;
            Commands command = ToCommand(inputString.Trim());

            switch (command)
            {
                case Commands.QUIT:
                    IsRunning = false;
                    break;
                case Commands.LOOK:
                    if (previousRoom != Player.Location)
                    {
                        Output.WriteLine(Player.Location.Description);
                        previousRoom = Player.Location;
                        Player.AddMoves();
                        Output.WriteLine($"{Player.Location}\n{Player.Location.Description}");
                    }
                    break;
                case Commands.NORTH:
                case Commands.SOUTH:
                case Commands.EAST:
                case Commands.WEST:
                    Directions direction = (Directions)command;
                    if (Player.Move(direction) == false)
                    {
                        Output.WriteLine("The way is shut!");
                        Player.AddMoves();
                    }
                    break;
                case Commands.SCORE:
                    Player.AddMoves();
                    Output.WriteLine($"Your score is {Player.score} in {Player.moves} move(s).");
                    break;
                case Commands.REWARD:
                    Player.AddScore();
                    Output.WriteLine("5 Score Obtained.");
                    break;

                default:
                    Output.WriteLine("Unknown command.");
                    break;
            }
        }

        private void DisplayWelcomeMessage()
        {
            Output.WriteLine(WelcomeMessage);
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
