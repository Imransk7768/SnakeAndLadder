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
        int DiePosition, position = 0, option, count;
        public int DieRoll()
        {
            Random random = new Random();
            DiePosition = random.Next(1, 7);
            Console.WriteLine("Die Roll Position is: " + DiePosition);
            return DiePosition;
        }
        public void GamePlay()
        {
            while (this.position < 100)
            {
                Random random = new Random();
                option = random.Next(0, 3);
                
                switch (option)
                {
                    case NoRoll:
                        this.position += 0;
                        break;
                    case Snake:
                        this.position -= this.DieRoll();
                        if (this.position < 0)
                        {
                            this.position = 0;
                        }
                        break;
                    case Ladder:
                        int maxValue = this.DieRoll();
                        this.position += maxValue;
                        if (this.position > 100)
                        {
                            this.position -= maxValue;
                        }
                        break;
                }
                count++;
            }
            Console.WriteLine("No Of Dice To Winning the Match" + "  " + count);
            Console.WriteLine("You Have Win With " + this.position + " " + " Number");
            Console.WriteLine("Die Rolled " + this.position);
        }
    }
}
