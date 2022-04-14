namespace BatailleNavale.View
{
   
    internal class CellView
    {
        public static void PrintCell(int x0, int y0, Char letter, ConsoleColor consoleColor)
        {
            UtilView.WriteAt("┌─┐", x0, y0, consoleColor);
            UtilView.WriteAt("│" + letter + "│", x0, y0 + 1, consoleColor);
            UtilView.WriteAt("└─┘", x0, y0 + 2, consoleColor);
        }
    }
    internal class InformationsView
    {

    }
    internal class MenuView
    {

    }
    internal class MatchView
    {

    }
    internal class MainView
    {

    }
    internal class UtilView
    {
        public static int origRow { get; set; }
        public static int origCol { get; set; }
        public static void WriteAt(string s, int x, int y, ConsoleColor backgroundColor)
        {
            try
            {
                Console.BackgroundColor = backgroundColor;
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s, Console.BackgroundColor);
                Console.ResetColor();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
        }
    }
    internal class GridView
    {
        public static void PrintEmptyGrid(int x0, int y0)
        {
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    CellView.PrintCell(x * 3 + x0, y * 3 + y0, ' ', ConsoleColor.Blue);
                }
            }
            Console.ResetColor();
        }
    }
    public class View
    {
        public static void PrintBoat(Boat boat, ConsoleColor consoleColor)
        {
            CellView.PrintCell(boat.x0, boat.y0, boat.Name, consoleColor);

            for (int i = 2; i <= boat.Size; i++)
            {
                if (boat.Orientation == 'V')
                {
                    CellView.PrintCell(boat.x0, boat.y0 + 3 * (i - 1), boat.Name, consoleColor);
                }
                else if (boat.Orientation == 'H')
                {
                    CellView.PrintCell(boat.x0 + 3 * (i - 1), boat.y0, boat.Name, consoleColor);
                }
            }
        }

        public static void PrintAllBoats(Player player)
        {
            foreach (var boat in player.ListOfBoats)
            {
                PrintBoat(boat, ConsoleColor.Yellow);
            }
        }
    }
    public class BoatView
    {
        public static void PrintBoat(Boat boat, ConsoleColor consoleColor)
        {
            CellView.PrintCell(boat.x0, boat.y0, boat.Name, consoleColor);

            for (int i = 2; i <= boat.Size; i++)
            {
                if (boat.Orientation == 'V')
                {
                    CellView.PrintCell(boat.x0, boat.y0 + 3 * (i - 1), boat.Name, consoleColor);
                }
                else if (boat.Orientation == 'H')
                {
                    CellView.PrintCell(boat.x0 + 3 * (i - 1), boat.y0, boat.Name, consoleColor);
                }
            }
        }

        public static void PrintAllBoats(Player player)
        {
            foreach (var boat in player.ListOfBoats)
            {
                PrintBoat(boat, ConsoleColor.Yellow);
            }
        }
    }
}


