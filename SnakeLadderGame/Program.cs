using System;
using SnakeLadderGame;
public class program
{
    public static void Main(String[] args)
    {
            Console.WriteLine(" Snake and ladder game");
            SnakeAndLadderGames game = new SnakeAndLadderGames();
            game.dicerollp1();
            game.dicerollp2();
            game.winner();
    }
}