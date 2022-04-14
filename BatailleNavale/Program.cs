
using BatailleNavale.View;

namespace BatailleNavale
{
    public class Program
    {

        public static void Main()
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            Player playerMy = new Player();
            playerMy.InitGrid();
            playerMy.InitBoat();

            Player Opponent = new Player();
            Opponent.InitGrid();

            //process.PutBoats(player1.Grid, player1.ListOfBoats);

            Networking.Server();
            
           
            bool coordsNotOK = true;
            
            while (coordsNotOK)
            {
                Process.CorrectCoords(playerMy.Grid, string coords);



                Console.Clear();
            }
            Displays.Display(player1.Grid);

            UtilView.WriteAt("All done!", 0, 50, ConsoleColor.Green);
            //Console.WriteLine();


        }

    }
}
