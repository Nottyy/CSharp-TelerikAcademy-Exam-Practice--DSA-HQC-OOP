namespace HelpDoge
{
    using System;
    using System.Numerics;

    internal class HelpDoge
    {
        private const int Enemy = -1;

        private static int n, m, fx, fy;

        private static BigInteger[,] field;

        private static void Main()
        {
            Input();

            var answer = Solve();

            Console.WriteLine(answer);
        }


        private static void Input()
        {
            // On the first line there will be the numbers N and M, separated by a single space.
            var line = Console.ReadLine().Split(' ');
            n = int.Parse(line[0]);
            m = int.Parse(line[1]);
            field = new BigInteger[n, m];
            var s = 4;

            // On the second line there will be the integer numbers Fx and Fy, separated by a single space.
            line = Console.ReadLine().Split(' ');
            fx = int.Parse(line[0]);
            fy = int.Parse(line[1]);

            // On the third line there will be the number K – the number of Doge`s enemies. Many enemies.
            var k = int.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                // On the next K lines there will be the X and Y coordinates for each Doge`s enemy, separated by a space.
                line = Console.ReadLine().Split(' ');
                var enemyX = int.Parse(line[0]);
                var enemyY = int.Parse(line[1]);

                field[enemyX, enemyY] = Enemy;
            }
        }

        /// <summary>
        /// Solving the task using dynamic programming technique.
        /// </summary>
        private static BigInteger Solve()
        {
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < m; y++)
                {
                    // Find Doge
                    if (x == 0 && y == 0)
                    {
                        field[x, y] = 1;
                        continue;
                    }

                    // If there is enemy set the value to 0
                    if (field[x, y] == Enemy)
                    {
                        field[x, y] = 0;
                        continue;
                    }

                    var top = x > 0 ? field[x - 1, y] : 0;
                    var left = y > 0 ? field[x, y - 1] : 0;

                    // calculate current possible ways
                    field[x, y] = top + left;

                    // if we hit the food, return all possible ways
                    if (x == fx && y == fy)
                    {
                        return field[x, y];
                    }
                }
            }

            return field[fx, fy];
        }
    }
}
