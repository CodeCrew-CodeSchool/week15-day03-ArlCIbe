using System.Globalization;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace tictactoe;
/*NOTE: The starter code for this assignment is no longer available, since we went over it together in class. I'm still going to attempt it on my own and will ask DJ if I get stuck.*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi! Welcome to your game of Tic-Tac-Toe!\n");
        Console.WriteLine("Here's your starting board:\n");
        Console.WriteLine("|1||2||3|");
        Console.WriteLine("|4||5||6|");
        Console.WriteLine("|5||6||9|\n");
        Console.WriteLine("The first player that get three markers in a diagonal, vertical, or horizontal line wins.\n");

        string[] markerArray = ["X", "x", "O", "o"];//used upper and lower case for better user experience; they may not notice which they're putting in
        string marker = Console.ReadLine()!;
        marker = ChooseMarker(markerArray, marker);

        string[] nameArray = new string[2];    
        string name = Console.ReadLine()!;//temporary placeholder for names
        name = ArrayName(nameArray, name);//
    
        Player player1 = new()
        {
            Name = name,
            Marker = marker
        };
        Console.WriteLine("Player 1, please enter your name: " + name);
        Console.WriteLine("Please either X or O: " + marker);
        Console.WriteLine(player1.Name + ", your marker is " + player1.Marker);

        Console.WriteLine("");
        
        Player player2 = new()
        {
            Name = name,
            Marker = marker
        };
        Console.WriteLine("Player 2, please enter your name: " + name);
        Console.WriteLine(player2.Name + ", your marker is " + player2.Marker);

        NameArray(nameArray, name);
    }
        public static string ArrayName(string[] nameArray, string name)
        {
            for (int nameInput = 0; nameInput >= nameArray.Length; nameInput++)
            {
                name = nameArray[nameInput];
            }
            return name;
        }//populates the nameArray with user input; stores the value of each nameArray element in name variable
        public static string[] NameArray(string[] nameArray, string name)
        {
            ArrayName(nameArray, name);
            return nameArray;
        }//calls the function that populates nameArray and then actually returns that it
        public static string ChooseMarker(string[] markerArray, string marker)
        {                   
            try
            {
                marker = Console.ReadLine()!;
                bool notExOrOh = marker != markerArray[1] || marker != markerArray[2] || marker != markerArray[3] || marker != markerArray[4];
                    if(notExOrOh)
                    {
                        throw new Exception("Error: Pleas choose either X or O.");
                    }
                return marker;
            }
            catch
            {
                throw;
            }
        }
        public class Player
        {//instance fields of each Player instance
            public string Marker;
            public string Name;
        }
        public class GameBoard
        {
            public string[] markerArray = ["X", "x", "O", "o"];
            public static string ChooseMarker(string[] markerArray, string marker){
                try
                {
                    marker = Console.ReadLine()!;
                    bool notExOrOh = marker != markerArray[1] || marker != markerArray[2] || marker != markerArray[3] || marker != markerArray[4];
                        if(notExOrOh)
                        {
                            throw new Exception("Error: Pleas choose either X or O.");
                        }
                    return marker;
                }
                catch
                {
                    throw;
                }
        }
        public class Game
        {
            public string[] markerArray = ["X", "x", "O", "o"];
            
            public static string ChooseMarker(string[] markerArray, string marker){
                try
                {
                    marker = Console.ReadLine()!;
                    bool notExOrOh = marker != markerArray[1] || marker != markerArray[2] || marker != markerArray[3] || marker != markerArray[4];
                        if(notExOrOh)
                        {
                            throw new Exception("Error: Pleas choose either X or O.");
                        }
                    return marker;
                }
                catch
                {
                    throw;
                }
            }
            public static string[] NameArray(string[] nameArray, string name)
            {
                ArrayName(nameArray, name);
                return nameArray;
            }
        }//switch between players - declare winner or tie - 
        public class Position
        {
            //apply markers to different positions on the board
        }
    }