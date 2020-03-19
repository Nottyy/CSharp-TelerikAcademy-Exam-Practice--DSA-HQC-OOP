using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Basic_Markup_Language
{
    class Program
    {
        const string stopCommand = "stop";
        const string inverseCom = "inverse";
        const string reverseCom = "reverse";
        const string repeatCom = "repeat";
        static int counter = 1;

        static void Main()
        {
            while (true)
            {
                string p = Console.ReadLine();
                var strings = p.Split(new[] { ' ', '<', '=', '/', '"', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var stringss = p.Split(new[] { '<', '=', '/', '"', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string firstCommand = strings[0];
                string commandValue = stringss[stringss.Length - 1];
                int contentIndex = Array.IndexOf(strings, "content");
                               
                if (firstCommand == stopCommand)
                {
                    break;
                }
                else
                {                    
                    switch (firstCommand)
                    {
                        case inverseCom:
                            Console.WriteLine("{0}. {1}", counter, Inverse(commandValue));
                            counter++;
                            break;
                        case reverseCom:
                            Console.WriteLine("{0}. {1}", counter, Reverse(commandValue));
                            counter++;
                            break;
                        case repeatCom:
                            Repeat(commandValue, int.Parse(strings[2]));
                            break;
                    }
                }
            }
        }

        static string Inverse(string line)
        {
            var sb = new StringBuilder(line.Length);
            for (int i = 0; i < line.Length; i++)
            {
                char currentChar = line[i];
                if (char.IsUpper(currentChar))
                {
                    sb.Append(char.ToLower(currentChar));
                }
                else if (char.IsLower(currentChar))
                {
                    sb.Append(char.ToUpper(currentChar));
                }
                else
                {
                    sb.Append(currentChar);
                }
            }
            return sb.ToString();
        }

        static string Reverse(string line)
        {
            char[] charArray = line.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Repeat(string line, int repeatValue)
        {
            for (int i = 0; i < repeatValue; i++)
            {
                Console.WriteLine("{0}. {1}", counter, line);
                counter++;
            }
        }
    }
}
