using System;

namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Welcome to your game of Tic-Tac-Toe!\n");

            string[] markerArray = { "X", "O" };

            Console.Write("Player 1, please enter your name: ");
            string player1Name = Console.ReadLine()!;//temporarily stores players' input
            string player1Marker = ChooseMarker(markerArray);

            Console.Write("Player 2, please enter your name: ");
            string player2Name = Console.ReadLine()!;
            string player2Marker = player1Marker == "X" ? "O" : "X";//player 2's marker is chosen based on player 1's marker choice
            //Player instances
            Player player1 = new Player
            {
                Name = player1Name,
                Marker = player1Marker
            };

            Player player2 = new Player
            {
                Name = player2Name,
                Marker = player2Marker
            };

            Console.WriteLine($"{player1.Name}, your marker is {player1.Marker}");
            Console.WriteLine($"{player2.Name}, your marker is {player2.Marker}");

            Game game = new Game(player1, player2);//constructor creates Game instance that passes in the the Player instances
            game.StartGame();
        }

        public static string ChooseMarker(string[] markerArray)
        {
            while (true)
            {
                Console.Write("Please choose either X or O: ");
                string marker = Console.ReadLine()!.ToUpper();//for better UX; players might not notice if they're using upper or lower case
                if (Array.Exists(markerArray, element => element == marker))//checks if user is entering anything other than x or o
                {
                    return marker;
                }
                else
                {
                    Console.WriteLine("Error: Please choose either X or O.");
                }
            }
        }
    }

    public class Player
    {
        public string Marker { get; set; }
        public string Name { get; set; }
    }

    public class Game
    {
        private Player player1;
        private Player player2;
        private string[,] board = new string[3, 3];
        private Player currentPlayer;

        public Game(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            currentPlayer = player1;
            InitializeBoard();
        }

        private void InitializeBoard()//creates the board in 3x3 lines
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = " ";
                }
            }
        }

        public void StartGame()
        {
            bool gameWon = false;//tracks game result
            while (!gameWon && !IsBoardFull())
            {
                DisplayBoard();//current board
                PlayerMove(currentPlayer);
                gameWon = CheckWin();//checks game result after each turn
                if (!gameWon)
                {
                    SwitchPlayer();//switches if game's not won
                }
            }
            DisplayBoard();//final board
            if (gameWon)
            {
                Console.WriteLine($"{currentPlayer.Name} wins!");
            }
            else
            {
                Console.WriteLine("It's a draw!");//board is full with no winner
            }
        }

        private void DisplayBoard()
        {
            Console.WriteLine("  0 1 2");//first row of board
            for (int i = 0; i < 3; i++)//runs for each column
            {
                Console.Write(i + " ");//adds spaces
                for (int j = 0; j < 3; j++)//runs for each row
                {
                    Console.Write(board[i, j]);//value of current cell
                    if (j < 2) Console.Write("|");//line only between columns
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine("  -----");//line only between 2 rows
            }
        }

        private void PlayerMove(Player player)
        {
            int row, col;
            while (true)
            {
                Console.WriteLine($"{player.Name}, it's your turn. Enter row and column (0, 1, 2):");
                string[] inputs = Console.ReadLine()!.Split(' ');//row and column choice
                if (inputs.Length == 2 && int.TryParse(inputs[0], out row) && int.TryParse(inputs[1], out col))//Checks if the player entered exactly two numbers convert input to row and the second to col.
                {
                    if (row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == " ")
                    {
                        board[row, col] = player.Marker;
                        break;
                    }
                }
                Console.WriteLine("Invalid move. Try again.");
            }
        }

        private void SwitchPlayer()
        {
            currentPlayer = currentPlayer == player1 ? player2 : player1;
        }

        private bool IsBoardFull()//every cell full with x or o
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == " ")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool CheckWin()
        {
            // Check rows, columns, and diagonals
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == currentPlayer.Marker && board[i, 1] == currentPlayer.Marker && board[i, 2] == currentPlayer.Marker) ||
                    (board[0, i] == currentPlayer.Marker && board[1, i] == currentPlayer.Marker && board[2, i] == currentPlayer.Marker))
                {
                    return true;
                }
            }
            if ((board[0, 0] == currentPlayer.Marker && board[1, 1] == currentPlayer.Marker && board[2, 2] == currentPlayer.Marker) ||
                (board[0, 2] == currentPlayer.Marker && board[1, 1] == currentPlayer.Marker && board[2, 0] == currentPlayer.Marker))
            {
                return true;
            }
            return false;
        }
    }
}
