using HQC_Exam___Computers.ComputerComponents.Contracts;
using System.Collections.Generic;

namespace HQC_Exam___Computers.Computers
{
    public class Laptop : BaseComputer
    {
        private const string BatteryChargedMessage = "Battery status: {0}";

        public Laptop(ICpu cpu, IRam ram, IVideoCard videoCard, IEnumerable<IHardDrive> hardDrives, IBattery laptopBattery) : base(cpu, ram, videoCard, hardDrives)
        {
            this.LaptopBattery = laptopBattery;
        }

        protected IBattery LaptopBattery { get; set; }

        public void ChargeBattery(int percentage)
        {
            this.LaptopBattery.Charge(percentage);

            VideoCard.Draw(string.Format(BatteryChargedMessage, LaptopBattery.Percentage));
        }
    }
}
