//Yuva Reddy
//05/02/25
//The Replicator of D'To


using System;
namespace Homework_2
{
	public class ArrayQ
	{
		public void copy()
		{
			int[] array = new int[5];
			for(int obj = 0; obj<5; obj++)
			{
				Console.WriteLine("Enter numbers: ");
				int num = Convert.ToInt32(Console.ReadLine());
				array[obj] = num;
			}

			int[] copy = new int[5];

            for (int number = 0; number < 5; number++)
                copy[number] = array[number];

            for (int numberr = 0; numberr < 5; numberr++)
                Console.WriteLine($"{array[numberr]} and {copy[numberr]}");
        }
	}
}

