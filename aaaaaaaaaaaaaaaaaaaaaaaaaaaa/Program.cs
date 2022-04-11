

using Common;

Game_Tic_Tac_Toe game = new Game_Tic_Tac_Toe();
string playerInput;
int playerInputField;
int winner = 0;

while (true)
{
    game.StartNewGame();
    DrawGameField();

    while (game.GameFinish == false)
    {
        do
        {
            PlayerChooseYourFild();
        } while (CheckUserInputIsValid() == false);
        winner = game.GetWinner();
        DrawGameField();
    }
    if (winner == -1)
    {
        Console.WriteLine("DRAW");
    }
    else
    {
        Console.WriteLine("Congrat Player {0}, you win!", winner);
    }

    Console.WriteLine("Press any key to restart the game.");
    Console.ReadKey();
}


bool CheckUserInputIsValid()
{
    if (CheckUserInputIsNumber())
    {
        if (game.checkInput(playerInputField))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Your input is not possible, try again.");
        }
    }

    return false;
}
bool CheckUserInputIsNumber()
{
    if (!int.TryParse(playerInput, out playerInputField))
    {
        Console.WriteLine("Please enter a number!");
        Console.WriteLine();
        return false;
    }
    return true;
}

void PlayerChooseYourFild()
{
    Console.WriteLine();
    Console.Write("Player {0}: Choose your field! :", game.currentPlayer);
    playerInput = Console.ReadLine();
}

void DrawGameField()
{
    Console.Clear();
    Console.WriteLine("     |     |    ");
    Console.WriteLine("  {0}  |  {1}  |  {2}  ", game.gameField[0, 0], game.gameField[0, 1], game.gameField[0, 2]);
    Console.WriteLine("     |     |    ");
    Console.WriteLine("─────┼─────┼────");
    Console.WriteLine("     |     |    ");
    Console.WriteLine("  {0}  |  {1}  |  {2}  ", game.gameField[1, 0], game.gameField[1, 1], game.gameField[1, 2]);
    Console.WriteLine("     |     |    ");
    Console.WriteLine("─────┼─────┼────");
    Console.WriteLine("     |     |    ");
    Console.WriteLine("  {0}  |  {1}  |  {2}  ", game.gameField[2, 0], game.gameField[2, 1], game.gameField[2, 2]);
    Console.WriteLine("     |     |     ");
}

