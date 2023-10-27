using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLite
{
    public class GameMethods
    {
        public static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output =  new PlayerInfoModel();

            Console.WriteLine($"Player information for {playerTitle}");

            // Ask the user fir their name
            output.UserName = RequestData.AskForUsersName();

            // Load up the shot grid
            GameLogic.InitializeGrid(output);

            // Ask the user for their 5 ship placements
            RequestData.PlaceShips(output);

            // Clear
            Console.Clear();
            return output;
        }
    }
}
