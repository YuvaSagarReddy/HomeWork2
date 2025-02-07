//Yuva Reddy
//05/02/25                      
//Buying Inventory and Discounted Inventory 

using System;
namespace Homework_2
{
	public class Inventory
	{
		public void inventory()
		{
            Console.WriteLine("The following items are available:");
            Console.WriteLine("1 - Rope");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equipment");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoe");
            Console.WriteLine("7 - Food Supplies");
            Console.WriteLine("What number do you want to see the price of? ");
            int objectNumber = Convert.ToInt32(Console.ReadLine());

            string object_ = objectNumber switch
            {
                1 => "Rope",
                2 => "Torches",
                3 => "Climbing Equipment",
                4 => "Clean Water",
                5 => "Machete",
                6 => "Canoe",
                7 => "Food Supplies"
            };

            int price = object_ switch
            {
                "Rope" => 10,
                "Torches" => 15,
                "Climbing Equipment" => 25,
                "Clean Water" => 1,
                "Machete" => 20,
                "Canoe" => 200,
                "Food Supplies" => 1
            };

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            if (name == "YUVA") price = price / 2;

            Console.WriteLine($"{object_} costs {price} gold.");

        }
    }
}

