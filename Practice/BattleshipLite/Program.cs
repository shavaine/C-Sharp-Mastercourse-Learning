using BattleshipLite;
using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;

ConsoleMessages.WelcomeMessage();

PlayerInfoModel activePlayer = GameMethods.CreatePlayer("Player 1");
PlayerInfoModel opponent = GameMethods.CreatePlayer("Player 2");
PlayerInfoModel winner = null;

do
{
    GameMethods.DisplayShotGrid(activePlayer);
    
    GameMethods.RecordPlayerShot(activePlayer, opponent);

    bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

    if (doesGameContinue == true)
    {
        // Swap positions
        (activePlayer, opponent) = (opponent, activePlayer);
    } 
    else
    {
        winner = activePlayer;
    }

} while (winner == null);

GameMethods.IdentifyWinner(winner);


Console.ReadLine();
