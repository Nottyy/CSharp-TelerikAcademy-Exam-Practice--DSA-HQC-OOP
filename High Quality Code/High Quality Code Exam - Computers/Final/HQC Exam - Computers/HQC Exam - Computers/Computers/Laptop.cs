using HQC_Exam___Computers.ComputerComponents.Contracts;
using System.Collections.Generic;

namespace HQC_Exam___Computers.Computers
{
    public class Laptop : BaseComputer
    {
        private const string BatteryChargedMessage = "Battery status: {0}";
        public Laptop(ICpu cpu, IVideoCard videoCard, IRam ram, IEnumerable<IHardDrive> hardDrives, IBattery laptopBattery) 
            : base(cpu, videoCard, ram, hardDrives)
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
