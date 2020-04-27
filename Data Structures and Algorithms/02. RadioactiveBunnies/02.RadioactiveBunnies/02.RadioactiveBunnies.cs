namespace _02.RadioactiveBunnies
{
    using System;
    using System.Collections.Generic;


    public class Program
    {
        public const string DeadMessage = "dead: {0} {1}";
        public const string WonMessage = "won: {0} {1}";
        public const char Up = 'U';
        public const char Down = 'D';
        public const char Left = 'L';
        public const char Right = 'R';
        static bool[,] bunnyLair;
        static List<Position> bunnies;

        static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' } , StringSplitOptions.RemoveEmptyEntries);
            var rows = int.Parse(input[0]);
            var cols = int.Parse(input[1]);

            bunnies = new List<Position>();
            bunnyLair = new bool[rows, cols];
            Position playerPosition = new Position();

            for (int row = 0; row < rows; row++)
            {
                var line = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    var currentChar = line[col];

                    if (currentChar == '.')
                    {
                        bunnyLair[row, col] = true;
                    }
                    else if (currentChar == 'B')
                    {
                        bunnyLair[row, col] = false;
                        bunnies.Add(new Position(row, col));
                    }
                    else if (currentChar == 'P')
                    {
                        playerPosition.Row = row;
                        playerPosition.Col = col;
                        bunnyLair[row, col] = true;
                    }
                }
            }

            var directions = Console.ReadLine();

            foreach (var move in directions)
            {
                var oldBunnies = new List<Position>(bunnies);
                bunnies.Clear();
                bunnies = SpreadBunnies(oldBunnies);

                int oldPlayerRow = playerPosition.Row;
                int oldPlayerCol = playerPosition.Col;

                switch (move)
                {
                    case 'U': playerPosition.Row--; break;
                    case 'D': playerPosition.Row++; break;
                    case 'L': playerPosition.Col--; break;
                    case 'R': playerPosition.Col++; break;
                }

                if (!CheckIfPositionsIsInsideArrayBorders(playerPosition.Row, playerPosition.Col))
                {
                    PrintMatrixAndMessage(string.Format(WonMessage, oldPlayerRow, oldPlayerCol));
                    return;
                }
                else if (!bunnyLair[playerPosition.Row, playerPosition.Col])
                {
                    PrintMatrixAndMessage(string.Format(DeadMessage, playerPosition.Row, playerPosition.Col));
                    return;
                }
            }
        }
        private static void UpdateBunnyPosition(int row, int col, List<Position> bunnies)
        {
            if (CheckIfPositionsIsInsideArrayBorders(row, col))
            {
                bunnyLair[row, col] = false;
                bunnies.Add(new Position(row, col));
            }
        }

        private static List<Position> SpreadBunnies(List<Position> bunnies)
        {
            var newBunnies = new List<Position>();
            foreach (var bunny in bunnies)
            {
                var rowPos = bunny.Row;
                var colPos = bunny.Col;

                UpdateBunnyPosition(rowPos + 1, colPos, newBunnies);
                UpdateBunnyPosition(rowPos - 1, colPos, newBunnies);
                UpdateBunnyPosition(rowPos, colPos + 1, newBunnies);
                UpdateBunnyPosition(rowPos, colPos - 1, newBunnies);
            }

            return newBunnies;
        }

        private static bool CheckIfPositionsIsInsideArrayBorders(int row, int col)
        {
            var rowLength = bunnyLair.GetLength(0);
            var colLength = bunnyLair.GetLength(1);
            if (row >= rowLength || row < 0 || col >= colLength || col < 0)
            {
                return false;
            }

            return true;
        }

        static void PrintMatrixAndMessage(string message)
        {
            for (int i = 0; i < bunnyLair.GetLength(0); i++)
            {
                for (int j = 0; j < bunnyLair.GetLength(1); j++)
                {
                    if (bunnyLair[i, j])
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("B");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine(message);
        }
    }
}
