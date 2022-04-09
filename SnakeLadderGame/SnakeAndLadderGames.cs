using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class SnakeAndLadderGames
    {
        int person1 = 0, person2 = 0;
        public int p1 = 0, p2 = 0;
        public void dicerollp1()
        {
            Random random = new Random();

            for (int i = 0; person1 != 100; i++)
            {
                int dice = random.Next(1, 7);
                int check = random.Next(0, 3);
                if (check == 2)
                {
                    person1 -= dice;
                }
                else if (check == 1)
                {
                    person1 += dice;
                }
                else
                {
                    person1 = 0 + person1;
                }
                if (person1 > 101)
                {
                    person1 -= dice;
                }
                if (person1 == 100)
                {
                    Console.WriteLine("person1 game is end in " + i + " steps");
                    p1 = i;
                }
            }
        }
        public void dicerollp2()
        {
            Random random = new Random();
            for (int j = 0; person2 != 100; j++)
            {
                int dice = random.Next(1, 7);
                int check = random.Next(0, 3);
                if (check == 2)
                {
                    person2 -= dice;
                }
                else if (check == 1)
                {
                    person2 += dice;
                }
                else
                {
                    person2 = 0 + person2;
                }
                if (person2 > 101)
                {
                    person2 -= dice;
                }
                if (person2 == 100)
                {
                    Console.WriteLine("person2 game is end in " + j + " steps");
                    p2 = j;
                }
            }
        }
        public void winner()
        {
            if (p1 > p2)
            {
                Console.WriteLine("person2 is winner");
            }
            else
            {
                Console.WriteLine("person1 is wiiner");
            }
        }
    }
}
