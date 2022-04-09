using System;
using SnakeLadderGame;
public class program
{
    public static void Main(String[] args)
    {
        SnakeAndLadderGames game = new SnakeAndLadderGames();
        game.DieRoll();
        game.GamePlay();
    }
}