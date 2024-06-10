using System.Globalization;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace tictactoe;

/* class - defines (aka declares) the properties (aka combo of INSTANCE FIELDS & INSTANCE METHODS) of its objects(aka INSTANCES)
    - instance - a singular object assembled from the properties designated by its class; though each object that a class produces has the same properties, the value of those properties are different for each object
        - instance field - variable that defines a single detail of an object
        - instance method - function that defines a thing/things that an object can do
*/

class Program
{
    static bool Main(string[] args)
    {
        Console.WriteLine("Hi! Welcome to your game of Tic-Tac-Toe.\n");

        Console.WriteLine("Here's the starting board:\n");

        Console.WriteLine("|1||2||3|");
        Console.WriteLine("|4||5||6|");
        Console.WriteLine("|5||6||7|\n");

        Console.WriteLine("The first player able to get three markers in a diagonal, vertical, or horizontal line wins.\n");

        string name = Console.ReadLine();
        string marker = Console.ReadLine();

        Players[] player = new Players[3];
        Players[] number = new Players[2];
        Players[] markers = new Players[2];

        player[0] = new Players($"{name}, {marker}, {number}");
        player[1] = new Players($"{name}, {marker}, {number}"); 

        markers[0] = new Players($"{player[0].Marker}");
        markers[1] = new Players($"{player[1].Marker}");

        number[0] = new Players($"{player[0].Name}");
        number[1] = new Players($"{player[1].Name}"); 

        Console.Write($"Player 1, please enter your name: {name}");

        Console.Write($"{player[0].Name}, please enter either X or O to choose your marker: {marker}\n");

        Console.WriteLine($"{player[0].Name}, your marker is {player[0].Marker}.\n");
      
        Console.WriteLine($"Player 2, please enter your name: {name}\n");

        Console.WriteLine($"{player[1].Name}, your marker is {player[1].Marker}. Press any key to start the game.\n");
        
}

class Players {

    public string Name;
    public string[] Markers;
    public string Marker;
    public int[] Number;
    //instance fields of each Player instance

    public Players(string name, string[] markers, int[] number, string marker){
    // constructor method; function used to initialize Player's fields (aka declare them and assign them a value at the same time)
        Name = name;
        Markers = markers;
        Number = number;
        Marker = marker;
    }
}

class GameBoard {

}

class Game {

} 

class Position {

}