using System;
using System.Collections.Generic;
using System.Text;

namespace HQC_Exam___Computers
{
    public class Computer
    {
        readonly LaptopBattery battery;

        internal Computer(ComputerType type, Cpu cpu, Rammstein ram, IEnumerable<HardDriver> hardDrives,
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
        Cpu Cpu { get; set; }
        Rammstein Ram { get; set; }

        public void ChargeBattery(int percentage)
        {
            battery.Charge(percentage);

            VideoCard.Draw(string.Format("Battery status: {0}", battery.Percentage));
        }
        public void Play(int guessNumber)
        {
            Cpu.rand(1, 10);
            var number = Ram.LoadValue();
            if (number + 1 != guessNumber + 1) VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            else VideoCard.Draw("You win!");
        }
        
        internal void Process(int data)
        {
            Ram.SaveValue(data);
            // TODO: Fix it
            Cpu.SquareNumber();
        }
    }
}
