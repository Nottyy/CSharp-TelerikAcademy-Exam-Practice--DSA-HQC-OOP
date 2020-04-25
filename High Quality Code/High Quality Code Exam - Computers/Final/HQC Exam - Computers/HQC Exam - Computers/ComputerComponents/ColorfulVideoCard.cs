namespace HQC_Exam___Computers.ComputerComponents
{
    using HQC_Exam___Computers.ComputerComponents.Contracts;
    using System;
    public class ColorfulVideoCard : MotherboardComponent, IVideoCard
    {
        private const ConsoleColor ColorfulVideoCardColor= ConsoleColor.Green;

        public void Draw(string msg)
        {
            Console.ForegroundColor = ColorfulVideoCardColor;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
