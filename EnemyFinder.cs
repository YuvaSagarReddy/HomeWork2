//Yuva Reddy
//05/02/25

using System;

namespace Homework_2
{
	public class EnemyFinder
	{
        public void direction(int x, int y)
		{
            if (x < 0 && y > 0) Console.WriteLine("The enemy is north west");
            else if (x == 0 && y > 0) Console.WriteLine("The enemy is north");
            else if (x > 0 && y > 0) Console.WriteLine("The enemy is north east");
            else if (x < 0 && y == 0) Console.WriteLine("The enemy is west");
            else if (x == 0 && y == 0) Console.WriteLine("The enemy is here");
            else if (x > 0 && y == 0) Console.WriteLine("The enemy is east");
            else if (x < 0 && y < 0) Console.WriteLine("The enemy is south west");
            else if (x == 0 && y < 0) Console.WriteLine("The enemy is south");
            else if (x > 0 && y < 0) Console.WriteLine("The enemy is south east");
        }
	}
}

