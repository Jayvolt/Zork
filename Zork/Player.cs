using System.Collections.Generic;
using Newtonsoft.Json;
namespace Zork
{
    public class Player
    {
        //Write a command named reward that ups the player's score
        //When type score - outputs score and moves "your score is 5 in 10 move(s)"
        //Write a command that counts moves and displays it (except unrecognized command)
        public World World { get; }

        [JsonIgnore]
        public Room Location { get; private set; }

        [JsonIgnore]
        public string LocationName
        {
            get
            {
                return Location?.Name;
            }
            set
            {
                Location = World?.RoomsByName.GetValueOrDefault(value);
            }
        }
        public int score = 0;
        public int moves = 0;
        public Player(World world, string startingLocation)
        {
            World = world;
            LocationName = startingLocation;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            if (isValidMove)
            {
                AddMoves();
                Location = destination;
            }
            return isValidMove;
        }

        public void AddScore()
        {
            score += 5;
            AddMoves();
        }
        public void AddMoves()
        {
            moves++;
        }
    }
}
