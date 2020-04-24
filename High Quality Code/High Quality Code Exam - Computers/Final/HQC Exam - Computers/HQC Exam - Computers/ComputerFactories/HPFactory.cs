namespace HQC_Exam___Computers.ComputerFactories
{
    using HQC_Exam___Computers.ComputerComponents;
    using HQC_Exam___Computers.Computers;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class HPFactory : AbstractComputerFactory
    {
        public const string HPFactoryName = "HP";
        public override Laptop CreateLaptop()
        {
            var laptopRam = new Ram(4);
            var laptopVideoCard = new ColorfulVideoCard();
            var laptopHardDrive = new HardDriver(500);
            var laptopCPU = new CPU64(2);

            return new Laptop(laptopCPU, laptopRam, laptopVideoCard, new[] { laptopHardDrive });
        }

        public override PC CreatePC()
        {
            var PCRam = new Ram(2);
            var PCVideoCard = new ColorfulVideoCard();
            var PCHardDrive = new HardDriver(500);
            var PCCPU = new CPU32(2);

            return new PC(PCCPU, PCRam, PCVideoCard, new[] { PCHardDrive });
        }

        public override Server CreateServer()
        {
            var ServerRam = new Ram(32);
            var ServerHardDrives = new[] { new HardDriver(1000), new HardDriver(1000) };
            var ServerCPU = new CPU32(4);

            return new Server(ServerCPU, ServerRam, ServerHardDrives);
        }
    }
}
