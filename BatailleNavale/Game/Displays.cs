namespace BatailleNavale
{
    public static class Displays
    {

        private static char ShowCell(Cell cell, int type)
        {

            char res = ' ';
            switch (type)
            {
                case 1:

                    if (cell.NumBoat != -1)
                    {
                        if (cell.AlreadyPlayed)
                            res = '0'; // bateau touché
                        else
                            res = 'B'; //bateau intact
                    }
                    break;
                case 2:
                    if (cell.NumBoat == -1)
                    {
                        if (cell.AlreadyPlayed)
                            res = 'X'; // loupé
                    }
                    else if (cell.AlreadyPlayed)
                        res = '0'; // bateau touché
                    break;
            }

            return res;
        }

        public static void Display(Cell[][] grid, int type = 2)
        {
            Console.WriteLine(" ---------------------------------------------------------- ");
            for (int i = 0; i < grid.Length; i++)
            {

                Console.Write("|  ");
                for (int j = 0; j < grid[i].Length; j++)
                    Console.Write(ShowCell(grid[i][j], type) + "  |  ");
                Console.WriteLine("\n ---------------------------------------------------------- ");
            }
        }
    }

}