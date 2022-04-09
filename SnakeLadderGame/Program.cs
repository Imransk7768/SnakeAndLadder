using System;
using SnakeLadderGame;
public class program
{
    public static void Main(String[] args)
    {
        SnakeAndLadderGames game = new SnakeAndLadderGames();
        int start = game.dieRoll();
        Console.WriteLine("Your Position is: " + "****" + start + "****");
    }
}