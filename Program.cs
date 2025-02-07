//Yuva Reddy
//05/02/25

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Watch tower

            Console.WriteLine("x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            EnemyFinder finder = new EnemyFinder();
            finder.direction(x, y);

            //Buying Inventory and Discounted inventory 

            Inventory type = new Inventory();
            type.inventory();

            //The prototype

            GuessingGame game = new GuessingGame();
            game.GetInput();
            game.PlayGame();

            //The magic cannon

            Magic magic = new Magic();
            magic.blast();

            //The Replicator of D’To

            ArrayQ copy = new ArrayQ();
            copy.copy();

        }
    }
}
