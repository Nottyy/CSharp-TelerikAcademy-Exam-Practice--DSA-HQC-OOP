using HQC_Exam___Computers.ComputerComponents.Contracts;
using System.Collections.Generic;

namespace HQC_Exam___Computers.Computers
{
    public class PC : BaseComputer
    {
        private const string PCDidNotGuessNumberMessage = "You didn't guess the number {0}.";
        private const string PCGuessedNumberMessage = "You win!";
        public PC(ICpu cpu, IRam ram, IVideoCard videoCard, IEnumerable<IHardDrive> hardDrives) : base(cpu, ram, videoCard, hardDrives)
        {
        }

        public void Play(int guessNumber)
        {
            this.CPU.GenerateRandomNumberAndSaveToRam(1, 10);
            var num = this.Ram.LoadValue();
            if (num != guessNumber)
            {
                this.VideoCard.Draw(string.Format(PCDidNotGuessNumberMessage, num));
            }
            else
            {
                this.VideoCard.Draw(PCGuessedNumberMessage);
            }
        }
    }
}
