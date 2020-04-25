using HQC_Exam___Computers.ComputerComponents.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace HQC_Exam___Computers.ComputerComponents
{
    public class MonochromeVideoCard : MotherboardComponent, IVideoCard
    {
        private const ConsoleColor MonochromeConsoleColor = ConsoleColor.Gray;

        public void Draw(string msg)
        {
            Console.ForegroundColor = MonochromeConsoleColor;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
