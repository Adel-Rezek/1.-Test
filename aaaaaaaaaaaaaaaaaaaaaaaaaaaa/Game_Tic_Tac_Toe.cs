using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Game_Tic_Tac_Toe
    {
        public string[,] gameField;
        public int currentPlayer;
        public bool GameFinish;
        public int countRounds = 0;

        public Game_Tic_Tac_Toe()
        {
            StartNewGame();
        }

        public void StartNewGame()
        {
            ResetGameField();
            currentPlayer = 1;
            GameFinish = false;
        }
        void ChangeCurrentPlayer()
        {
            if (currentPlayer == 1)
            {
                currentPlayer = 2;
            }
            else
            {
                currentPlayer = 1;
            }
        }
        public int GetWinner()
        {
            //{ 00, 01, 02 },
            //{ 10, 11, 12 },
            //{ 20, 21, 22 }

            // [,=] und summe aus 3
            if (countRounds == 9)
            {
                GameFinish = true;
                return -1;
            }
            else if (gameField[0, 2] == gameField[1, 1] && gameField[1, 1] == gameField[2, 0])
            {
                GameFinish = true;
                if (gameField[0, 2] == "X")
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else if (gameField[0, 0] == gameField[1, 1] && gameField[1, 1] == gameField[2, 2])
            {
                GameFinish = true;
                if (gameField[0, 0] == "X")
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                if (gameField[i, 0] == gameField[i, 1] && gameField[i, 1] == gameField[i, 2])
                {
                    GameFinish = true;
                    if (gameField[i, 0] == "X")
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else if (gameField[0, i] == gameField[1, i] && gameField[1, i] == gameField[2, i])
                {
                    GameFinish = true;
                    if (gameField[0, i] == "X")
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
            return 0;
        }
        public bool checkInput(int input)
        {
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    if (input.ToString() == gameField[i, j])
                    {
                        if (currentPlayer == 1)
                        {
                            gameField[i, j] = "X";
                        }
                        else
                        {
                            gameField[i, j] = "O";
                        }
                        countRounds++;
                        ChangeCurrentPlayer();
                        return true;
                    }
                }
            }
            return false;
        }
        void ResetGameField()
        {
            string[,] startField =
             {
                {"1", "2" ,"3"},
                {"4", "5", "6"},
                {"7", "8", "9"}
            };
            gameField = startField;
        }
    }
}
