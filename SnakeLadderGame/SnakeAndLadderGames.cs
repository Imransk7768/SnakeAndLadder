using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class SnakeAndLadderGames
    {
        int DiePosition;
        public int DieRoll()
        {
            Random random = new Random();
            DiePosition = random.Next(1, 7);
            Console.WriteLine("Die Roll Position is: " + DiePosition);
            return DiePosition;
        }
    }
}
