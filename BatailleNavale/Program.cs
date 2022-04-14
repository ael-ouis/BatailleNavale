
using BatailleNavale.View;

namespace BatailleNavale
{
    public class Program
    {

        public static void Main()
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            Player player1 = new Player();
            player1.InitGrid();
            player1.InitBoat();

            Player player2 = new Player();
            player2.InitGrid();
            

            Process process = new();

            process.PutBoats(player1.Grid, player1.ListOfBoats);
           
            //while (true)
            //{
            //    //Displays.Display(Player.Grid);
            //    //process.Target(Player.Grid);

            //    Console.Clear();
            //}

            //GridView.PrintEmptyGrid(0, 0);
            //GridView.PrintEmptyGrid(50, 0);


           
            /*BoatView.PrintBoat(boat1, ConsoleColor.Green);
            BoatView.PrintBoat(boat2, ConsoleColor.Yellow);
            BoatView.PrintBoat(boat3, ConsoleColor.Magenta);
            BoatView.PrintBoat(boat4, ConsoleColor.DarkCyan);

*/
            UtilView.WriteAt("All done!", 0, 50, ConsoleColor.Green);
            //Console.WriteLine();


        }

    }
}
