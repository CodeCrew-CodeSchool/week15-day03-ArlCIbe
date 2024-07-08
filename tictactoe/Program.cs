using System.Globalization;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace tictactoe;

/* class - defines (aka declares) the properties (aka combo of INSTANCE FIELDS & INSTANCE METHODS) of its objects(aka INSTANCES)
    - instance - a singular object assembled from the properties designated by its class; though each object that a class produces has the same properties, the value of those properties are different for each object
        - instance field - variable that defines a single detail of an object
        - instance method - function that defines a thing/things that an object can do
*/

namespace tictactoe;

class Player {
    public string id;
    public string marker;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my tic tac toe game!\n");
        Console.WriteLine("Press key to continue");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("You are player 1. You will be using X\n");
        Console.WriteLine("Press key to continue");
        Console.ReadLine();
        Console.Clear();

        string[][] gameBoard = [
            ["1", "2", "3"],
            ["4", "5", "6"],
            ["7", "8", "9"]
        ];


        Player player1 = new Player();
        player1.id = "1";
        player1.marker = "X";

        
        Player player2 = new Player();
        player2.id = "2";
        player2.marker = "O";



        Player currentPlayer = player1;
        bool gameOver = false;
        while(gameOver != true){
            Console.WriteLine("This is the board\n");
            DisplayBoard(gameBoard);

            Console.WriteLine($"\nPlayer {currentPlayer.id}. Make a move!");
            string playerChoice =  Console.ReadLine();
            MarkBoard(playerChoice, currentPlayer, gameBoard);

            Console.Clear();

            //switch the current player
            if(currentPlayer.id == "1"){
                currentPlayer = player2;
            }
            else if (currentPlayer.id == "2"){
                currentPlayer = player1;
            }
        }
        
    }

    static void DisplayBoard(string[][] board){
        for(int i = 0; i < board.Length; i++){
            string[] row = board[i];
            for(int x = 0; x < row.Length; x++){
                string value = row[x];
                Console.Write("|" + value + "|");
            }
            Console.WriteLine();
        }
    }

    static void MarkBoard(string playerChoice, Player currentPlayer, string[][] gameBoard){
            if(playerChoice == "1"){
                if(gameBoard[0][0] ==  "X" || gameBoard [0][0] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[0][0] = currentPlayer.marker;
            }
            else if (playerChoice == "2"){
                if(gameBoard[0][1] ==  "X" || gameBoard [0][1] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[0][1] = currentPlayer.marker;
            }
            else if (playerChoice == "3"){
                if(gameBoard[0][2] ==  "X" || gameBoard [0][2] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[0][2] = currentPlayer.marker;
            }
            else if (playerChoice == "4"){
                if(gameBoard[1][0] ==  "X" || gameBoard [1][0] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[1][0] = currentPlayer.marker;
            }
            else if (playerChoice == "5"){
                if(gameBoard[1][1] ==  "X" || gameBoard [1][1] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[1][1] = currentPlayer.marker;
            }
            else if (playerChoice == "6"){
                if(gameBoard[1][2] ==  "X" || gameBoard [1][2] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[1][2] = currentPlayer.marker;
            }
            else if (playerChoice == "7"){
                if(gameBoard[2][0] ==  "X" || gameBoard [2][0] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[2][0] = currentPlayer.marker;
            }
            else if (playerChoice == "8"){
                if(gameBoard[2][1] ==  "X" || gameBoard [2][1] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[2][1] = currentPlayer.marker;
            }
            else if (playerChoice == "9"){
                if(gameBoard[2][2] ==  "X" || gameBoard [2][2] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[2][2] = currentPlayer.marker;
            }
    }


}









// class Program
// {
//     static bool Main(string[] args)
//     {
//         Console.WriteLine("Hi! Welcome to your game of Tic-Tac-Toe.\n");

//         Console.WriteLine("Here's the starting board:\n");

//         Console.WriteLine("|1||2||3|");
//         Console.WriteLine("|4||5||6|");
//         Console.WriteLine("|5||6||7|\n");

//         Console.WriteLine("The first player able to get three markers in a diagonal, vertical, or horizontal line wins.\n");

//         string name = Console.ReadLine();
//         string marker = Console.ReadLine();

//         Players[] player = new Players[3];
//         Players[] number = new Players[2];
//         Players[] markers = new Players[2];

//         player[0] = new Players($"{name}, {marker}, {number}");
//         player[1] = new Players($"{name}, {marker}, {number}"); 

//         markers[0] = new Players($"{player[0].Marker}");
//         markers[1] = new Players($"{player[1].Marker}");

//         number[0] = new Players($"{player[0].Name}");
//         number[1] = new Players($"{player[1].Name}"); 

//         Console.Write($"Player 1, please enter your name: {name}");

//         Console.Write($"{player[0].Name}, please enter either X or O to choose your marker: {marker}\n");

//         Console.WriteLine($"{player[0].Name}, your marker is {player[0].Marker}.\n");
      
//         Console.WriteLine($"Player 2, please enter your name: {name}\n");

//         Console.WriteLine($"{player[1].Name}, your marker is {player[1].Marker}. Press any key to start the game.\n");
        
// }

// class Players {

//     public string Name;
//     public string[] Markers;
//     public string Marker;
//     public int[] Number;
//     //instance fields of each Player instance

//     public Players(string name, string[] markers, int[] number, string marker){
//     // constructor method; function used to initialize Player's fields (aka declare them and assign them a value at the same time)
//         Name = name;
//         Markers = markers;
//         Number = number;
//         Marker = marker;
//     }
// }

// class GameBoard {

// }

// class Game {

// } 

// class Position {

// }