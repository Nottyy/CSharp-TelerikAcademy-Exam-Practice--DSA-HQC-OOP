using HQC_Exam___Computers.ComputerComponents;
using HQC_Exam___Computers.ComputerComponents.Contracts;
using HQC_Exam___Computers.Contracts;
using System.Collections.Generic;

namespace HQC_Exam___Computers.Computers
{
    public class BaseComputer
    {
        public BaseComputer(ICpu cpu, IRam ram, IVideoCard videoCard, IEnumerable<IHardDrive> hardDrives)
        {
            this.CPU = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
            this.Motherboard = new MotherBoard(videoCard, ram, cpu);
        }

        public IMotherboard Motherboard { get; private set; }
        protected IEnumerable<IHardDrive> HardDrives { get; private set; }
        protected IVideoCard VideoCard { get; private set; }
        protected IRam Ram { get; private set; }
        protected ICpu CPU { get; private set; }
    }
}
