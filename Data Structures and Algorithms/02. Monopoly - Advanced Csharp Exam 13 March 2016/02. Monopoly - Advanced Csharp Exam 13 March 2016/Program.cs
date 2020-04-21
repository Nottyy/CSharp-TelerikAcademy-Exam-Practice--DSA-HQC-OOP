using System;

namespace _02._Monopoly___Advanced_Csharp_Exam_13_March_2016
{
    class Program
    {
        static void Main()
        {
            string[] dimensions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);
            int evenOrOdd = 1;
            int money = 50;
            int turns = 0;
            int hotelsOwned = 0;

            for (int row = 0; row < rows; row++)
            {
                string lineCommands = Console.ReadLine();
                
                for (int col = 0; col < cols; col++)
                {
                    int index = ((evenOrOdd % 2 != 0) ? col : (cols - col - 1));
                    switch (lineCommands[index])
                    {
                        case 'H':
                            hotelsOwned++;
                            Console.WriteLine("Bought a hotel for {0}. Total hotels: {1}.", money, hotelsOwned);
                            //
                            money = 0;
                            break;
                        case 'J':
                            Console.WriteLine("Gone to jail at turn {0}.", turns);
                            turns += 2;
                            money += 2 * (hotelsOwned * 10);
                            break;
                        case 'S':
                            int columnIndex = row % 2 == 0 ? col : index;
                            int moneyToSpent = money < ((row + 1) * (columnIndex + 1)) ? money : (row + 1) * (columnIndex + 1);
                            money -= moneyToSpent;
                            Console.WriteLine("Spent {0} money at the shop.", moneyToSpent);
                            break;
                    }
                    money += hotelsOwned * 10;
                    turns++;
                }
               
                evenOrOdd++;
            }

            Console.WriteLine("Turns {0}", turns);
            Console.WriteLine("Money {0}", money);
        }
    }
}
