using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Jedi_Meditation
{
    class Program
    {
        StringBuilder sb = new StringBuilder();
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            var padawansNoYoda = new List<string>();
            var padawansWithYoda = new List<string>();
            var jediMasters = new List<string>();
            var jediKnights = new List<string>();
            var jediPadawans = new List<string>();

            var tempPadawansTS = new List<string>();

            for (int i = 0; i < N; i++)
            {
                var allJedis = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < allJedis.Length; j++)
                {
                    var currentJedi = allJedis[j];
                    char jediType = currentJedi[0];

                    switch (jediType)
                    {
                        case 'm':
                            jediMasters.Add(currentJedi);
                            break;
                        case 'p':
                            jediPadawans.Add(currentJedi);
                            break;
                        case 'k':
                            jediKnights.Add(currentJedi);
                            break;
                        case 'y':
                            padawansWithYoda.AddRange(tempPadawansTS);
                            tempPadawansTS.Clear();
                            break;
                        case 't':
                            tempPadawansTS.Add(currentJedi);
                            break;
                        case 's':
                            tempPadawansTS.Add(currentJedi);
                            break;
                    }
                }
            }

            if (tempPadawansTS.Count > 0)
            {
                padawansNoYoda.AddRange(tempPadawansTS);
            }
            var result = "";

            var resultNoYoda = string.Join(" ", padawansNoYoda);
            if (!string.IsNullOrEmpty(resultNoYoda))
            {
                result += " " + resultNoYoda;
            }

            var resultMasters = string.Join(" ", jediMasters);
            if (!string.IsNullOrEmpty(resultMasters))
            {
                result += " " + resultMasters;
            }

            var resultKnights = string.Join(" ", jediKnights);
            if (!string.IsNullOrEmpty(resultKnights))
            {
                result += " " + resultKnights;
            }

            var resultWithYoda = string.Join(" ", padawansWithYoda);
            if (!string.IsNullOrEmpty(resultWithYoda))
            {
                result += " " + resultWithYoda;
            }

            var resultPadawans = string.Join(" ", jediPadawans);
            if (!string.IsNullOrEmpty(resultPadawans))
            {
                result += " " + resultPadawans;
            }

            Console.WriteLine(result.Trim());
        }
    }
}
