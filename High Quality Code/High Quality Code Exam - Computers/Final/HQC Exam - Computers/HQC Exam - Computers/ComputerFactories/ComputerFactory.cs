using System.Linq;
using HQC_Exam___Computers.Common;
using HQC_Exam___Computers.ComputerComponents;
using HQC_Exam___Computers.ComputerComponents.Contracts;
using HQC_Exam___Computers.Computers;

namespace HQC_Exam___Computers.ComputerFactories
{
    public class ComputerFactory : IComputerFactory
    {
        public Laptop CreateLaptop(int ram, VideoCardTypes videoCardType, int[] hardDrivesCapacity, int cpuBit, byte cpuCores)
        {
            var laptopRam = new Ram(ram);
            var laptopVideoCard = this.CreateVideoCard(videoCardType);
            var laptopHardDrives = hardDrivesCapacity.Select(x => new HardDriver(x));
            var laptopCPU = this.CreateCpu(cpuBit, cpuCores);

            return new Laptop(laptopCPU, laptopRam, laptopVideoCard, laptopHardDrives);
        }

        public PC CreatePC(int ram, VideoCardTypes videoCardType, int[] hardDriveCapacity, int cpuBit, byte cpuCores)
        {
            var PCRam = new Ram(ram);
            var PCVideoCard = this.CreateVideoCard(videoCardType);
            var PCHardDrives = hardDriveCapacity.Select(x => new HardDriver(x));
            var PCCPU = this.CreateCpu(cpuBit, cpuCores);

            return new PC(PCCPU, PCRam, PCVideoCard, PCHardDrives);
        }

        public Server CreateServer(int ram, int[] hardDriveCapacity, int cpuBit, byte cpuCores)
        {
            var ServerRam = new Ram(ram);
            var ServerHardDrives = hardDriveCapacity.Select(x => new HardDriver(x));
            var ServerCPU = this.CreateCpu(cpuBit, cpuCores);

            return new Server(ServerCPU, ServerRam, ServerHardDrives);
        }

        private IVideoCard CreateVideoCard(VideoCardTypes type)
        {
            IVideoCard videoCard;
            if (type == VideoCardTypes.ColorFul)
            {
                videoCard = new ColorfulVideoCard();
            }
            else
            {
                videoCard = new MonochromeVideoCard();
            }

            return videoCard;
        }

        private ICpu CreateCpu(int cpuBit, byte cpuCores)
        {
            ICpu cpu;
            switch (cpuBit)
            {
                case 64:
                    cpu = new CPU64(cpuCores);
                    break;
                case 128:
                    cpu = new CPU128(cpuCores);
                    break;
                default:
                    cpu = new CPU32(cpuCores);
                    break;
            }

            return cpu;
        }
    }
}
