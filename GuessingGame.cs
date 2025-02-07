//Yuva Reddy
//05/02/25
//The prototype



using System;
namespace Homework_2
{
	public class GuessingGame
	{
		private int number;

		public void GetInput()
		{
			do
			{
				Console.WriteLine();
				number = Convert.ToInt32(Console.ReadLine());
			}
			while (number < 0 && number > 100);

		}

		public void PlayGame()
		{
            Console.Clear();
            Console.WriteLine("User 2, guess the number.");

			while (true)
			{
				Console.Write("What is your next guess? ");
				int guess = Convert.ToInt32(Console.ReadLine());

				if (guess > number)
				{
					Console.WriteLine($"{guess} is too high.");
				}
				else if (guess < number)
				{
					Console.WriteLine($"{guess} is too low.");
				}
				else if (guess == number)
				{
					break;
				}
			}

            Console.WriteLine("You guessed the number!");
        }
	}
}



