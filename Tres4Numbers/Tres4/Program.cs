using System;
using System.Linq;
using System.Text;

namespace Tres4
{
    class Program
    {
        static readonly string[] TresNumFourDigits = new string[9]
          {
            "LON+",
            "VK-",
            "*ACAD",
            "^MIM",
            "ERIK|",
            "SEY&",
            "EMY>>",
            "/TEL",
            "<<DON"
         };

        static void Main(string[] args)
        {
            ulong num = ulong.Parse(Console.ReadLine());
            string word = ConvertWord(num);
            Console.WriteLine(word);
        }

        static string ConvertWord(ulong num)
        {
            string word = num.ToString();
            var getCodeAsString = word.Select(x => TresNumFourDigits[x - '0']);
            string result = string.Join(string.Empty, getCodeAsString);

            return result;
        }
    }
}
