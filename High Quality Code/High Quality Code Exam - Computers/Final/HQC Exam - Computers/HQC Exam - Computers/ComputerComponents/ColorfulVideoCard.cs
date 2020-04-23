namespace HQC_Exam___Computers.ComputerComponents
{
    using HQC_Exam___Computers.ComputerComponents.Contracts;
    using System;
    public class ColorfulVideoCard : IVideoCard
    {
        private const ConsoleColor ColorfulVideoCardColor= ConsoleColor.Green;

        public void Draw(string msg)
        {
            Console.BackgroundColor = ColorfulVideoCardColor;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
