using System;
using System.Collections.Generic;

namespace Events.Models
{
    public class TeamModel
    {
        public event EventHandler<string> MaxedPlayers;
        public string Name { get; set; }
        public List<PlayerModel> Players { get; set; } = new List<PlayerModel>();
        public int MaximumPlayers { get; set; }

        public string AddPlayer(PlayerModel player)
        {
            string output = "";
            if (Players.Count > MaximumPlayers)
            {
                output = $"{player.PlayerName} could not be added to {Name}. Team Full.";
                MaxedPlayers?.Invoke(this, $"{player.PlayerName} could not be added to {Name}. Team Full.");
            }
            else
            {
                Players.Add(player);
                output = $"{player.PlayerName} was successfully added to {Name}";
            }
            return output;
        }
    }
}
