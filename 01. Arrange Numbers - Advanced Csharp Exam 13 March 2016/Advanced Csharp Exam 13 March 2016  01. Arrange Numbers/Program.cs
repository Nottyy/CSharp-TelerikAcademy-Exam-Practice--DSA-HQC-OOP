using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_Csharp_Exam_13_March_2016__01._Arrange_Numbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string dig = "";
            List<Word> sortedList1 = new List<Word>();
            Word newWord = new Word();

            for (int ind = 0; ind < input.Length; ind++)
            {
                char inputt = input[ind];
                if (inputt == ',')
                {
                    ind += 1;
                    CheckWord(dig, newWord);
                    sortedList1.Add(newWord);
                    newWord = new Word();
                    dig = "";
                }
                else
                {
                    dig += input[ind].ToString();
                }
            }

            CheckWord(dig, newWord);
            sortedList1.Add(newWord);
            IEnumerable<Word> list = sortedList1.OrderBy(x => x.DigitName);

            string str = "";
            int paf = 0;

            foreach (var i in list)
            {
                if (paf == 0 || paf == list.Count())
                {
                    str += i.Digit;
                }
                else
                {
                    str += ", " + i.Digit;
                }
                paf++;
            }


            Console.WriteLine(str);
        }

        public class Word { 
            public int Digit { get; set; }
            public string DigitName { get; set; }
        }

        static void CheckWord(string dig, Word newWord)
        {
            if (dig.Length > 1)
            {
                newWord.DigitName = CheckLongerWord(dig);
                newWord.Digit = Int32.Parse(dig);
            }
            else
            {
                newWord.Digit = dig[0] - '0';
                newWord.DigitName = GetDigitString(dig[0] - '0');
            }
        }

        static string CheckLongerWord(string dig)
        {
            string word = "";
            for (int i = 0; i < dig.Length; i++)
            {
                if (i == 0 || i == dig.Length)
                {
                    word += GetDigitString(dig[i] - '0');
                }
                else
                {
                    word += "-" + GetDigitString(dig[i] - '0');
                }
            }

            return word;
        }
        

        static string GetDigitString(int digitName)
        {
            string stringName = "";
            switch (digitName)
            {
                case 0:
                    stringName = "zero";
                    break;
                case 1:
                    stringName = "one";
                    break;
                case 2:
                    stringName = "two";
                    break;
                case 3:
                    stringName = "three";
                    break;
                case 4:
                    stringName = "four";
                    break;
                case 5:
                    stringName = "five";
                    break;
                case 6:
                    stringName = "six";
                    break;
                case 7:
                    stringName = "seven";
                    break;
                case 8:
                    stringName = "eight";
                    break;
                case 9:
                    stringName = "nine";
                    break;
                default:
                    break;
            }

            return stringName;
        }
    }
}
