using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class SnakeAndLadderGames
    {
        const int NoRoll = 0, Snake = 1, Ladder = 2;
        int DiePosition, position = 0;
        public int DieRoll()
        {
            Random random = new Random();
            DiePosition = random.Next(1, 7);
            Console.WriteLine("Die Roll Position is: " + DiePosition);
            return DiePosition;
        }
        public void Game()
        {
            Random random = new Random();
            int option = random.Next(0, 3);
            switch (option)
            {
                case NoRoll:
                    this.position = 0;
                    break;
                case Snake:
                    this.position -= this.DieRoll();
                    break;
                case Ladder:
                    this.position += this.DieRoll();
                    break;
            }
        }
    }
}
