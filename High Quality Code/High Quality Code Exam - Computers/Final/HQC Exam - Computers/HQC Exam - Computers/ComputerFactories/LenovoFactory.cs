using HQC_Exam___Computers.ComputerComponents;
using HQC_Exam___Computers.Computers;

namespace HQC_Exam___Computers.ComputerFactories
{
    public class LenovoFactory : AbstractComputerFactory
    {
        public const string LENOVOFactoryName = "Lenovo";
        public override Laptop CreateLaptop()
        {
            var laptopRam = new Ram(16);
            var laptopVideoCard = new ColorfulVideoCard();
            var laptopHardDrive = new HardDriver(1000);
            var laptopCPU = new CPU64(2);

            return new Laptop(laptopCPU, laptopRam, laptopVideoCard, new[] { laptopHardDrive });
        }

        public override PC CreatePC()
        {
            var PCRam = new Ram(4);
            var PCVideoCard = new MonochromeVideoCard();
            var PCHardDrive = new HardDriver(2000);
            var PCCPU = new CPU64(2);

            return new PC(PCCPU, PCRam, PCVideoCard, new[] { PCHardDrive });
        }

        public override Server CreateServer()
        {
            var ServerRam = new Ram(8);
            var ServerHardDrives = new[] { new HardDriver(500), new HardDriver(500) };
            var ServerCPU = new CPU128(2);

            return new Server(ServerCPU, ServerRam, ServerHardDrives);
        }
    }
}
