using System;
using System.Collections.Generic;
using System.Text;

namespace HQC_Exam___Computers
{
    public class Computer
    {

        readonly LaptopBattery battery;

        internal Computer(ComputerType type, CPU cpu, Ram ram, IEnumerable<HardDriver> hardDrives,
            HardDriver videoCard, LaptopBattery battery)
        {
            Cpu = cpu;
            Ram = ram;
            HardDrives = hardDrives;
            VideoCard = videoCard;
            if (type != ComputerType.LAPTOP && type != ComputerType.PC)
            {
                VideoCard.IsMonochrome = true;
            }

            this.battery = battery;
        }

        IEnumerable<HardDriver> HardDrives { get; set; }
        HardDriver VideoCard { get; set; }
        CPU Cpu { get; set; }
        Ram Ram { get; set; }

        public void ChargeBattery(int percentage)
        {
            if (percentage < 0)
            {

            }
            battery.Charge(percentage);

            VideoCard.Draw(string.Format("Battery status: {0}", battery.Percentage));
        }
        public void Play(int guessNumber)
        {
            var num = this.GenerateRandomNumber(1, 10);
            if (num != guessNumber)
            {
                VideoCard.Draw(string.Format("You didn't guess the number {0}.", num));
            }
            else
            {
                VideoCard.Draw("You win!");
            }
        }

        public int GenerateRandomNumber(int a, int b)
        {
            var rand = new Random();
            int randomNumber = rand.Next(a, b);

            return randomNumber;
        }

        internal void Process(int data)
        {
            Ram.SaveValue(data);
            // TODO: Fix it
            Cpu.SquareNumber();
        }
    }
}
