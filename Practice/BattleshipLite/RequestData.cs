﻿using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLite
{
    public static class RequestData
    {
        public static string AskForUsersName()
        {
            Console.Write("What is your name: ");
            string output = Console.ReadLine();
            return output;
        }

        public static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"Where do you want to place ship number {model.ShipLocations.Count + 1}: ");
                string location = Console.ReadLine();

                bool isValidLocation = false;

                try
                {
                    isValidLocation = GameLogic.PlaceShip(model, location);
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Error: {ex.Message}");
                }

                if (isValidLocation == false)
                {
                    Console.WriteLine("That was not a valid location. Please try again.");
                }

            } while (model.ShipLocations.Count < 5);
        }

        public static string AskForShot(PlayerInfoModel player)
        {
            Console.Write($"{player.UserName}, Please enter your shot selection: ");
            string output = Console.ReadLine();

            return output;
        }
    }
}
