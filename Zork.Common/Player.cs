using System;
using Newtonsoft.Json;

namespace Zork.Common
{
    public class Player
    {
        public World World { get; }

        public EventHandler<Room> LocationChanged;
        public EventHandler<int> AddedMove;
        public EventHandler<int> AddedScore;

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
                LocationChanged?.Invoke(this, destination);
            }
            return isValidMove;
        }

        public void AddScore()
        {
            score += 5;
            AddedScore?.Invoke(this, score);
            AddMoves();
        }
        public void AddMoves()
        {
            moves++;
            AddedMove?.Invoke(this, moves);
        }

    }
}
