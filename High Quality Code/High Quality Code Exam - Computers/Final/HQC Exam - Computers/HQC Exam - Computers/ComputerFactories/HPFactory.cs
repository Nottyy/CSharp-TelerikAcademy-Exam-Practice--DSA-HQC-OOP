namespace HQC_Exam___Computers.ComputerFactories
{
    using HQC_Exam___Computers.Common;
    using HQC_Exam___Computers.ComputerComponents;
    using HQC_Exam___Computers.Computers;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class HPFactory : AbstractManufacturerFactory
    {
        public const string HPFactoryName = "HP";

        private const int HPDefaultLaptopRam = 4;
        private const int HPDefaultPCRam = 2;
        private const int HPDefaultServerRam = 32;

        private const VideoCardTypes HPDefaultLaptopVideoCardType = VideoCardTypes.ColorFul;
        private const VideoCardTypes HPDefaultPCVideoCardType = VideoCardTypes.ColorFul;

        private readonly int[] HPDefaultLaptopHardDriveCapacity = new int[1] { 500 };
        private readonly int[] HPDefaultPCHardDriveCapacity = new int[] { 500 };
        private readonly int[] HPDefaultServerHardDriveCapacity = new int[] { 1000, 1000 };

        private const int HPDefaultLaptopCpuBytes = 64;
        private const int HPDefaultPCCpuBytes = 32;
        private const int HPDefaultServerCpuBytes = 32;

        private const byte HPDefaultLaptopCpuCores = 2;
        private const byte HPDefaultPCCpuCores = 2;
        private const byte HPDefaultServerCpuCores = 2;

        public HPFactory(IComputerFactory compFactory) : base(compFactory)
        {
        }

        public override Laptop CreateLaptop()
        {
            return this.ComputerFactory.CreateLaptop(HPDefaultLaptopRam, HPDefaultLaptopVideoCardType,
                HPDefaultLaptopHardDriveCapacity, HPDefaultLaptopCpuBytes, HPDefaultLaptopCpuCores);
        }

        public override PC CreatePC()
        {
            return this.ComputerFactory.CreatePC(HPDefaultPCRam, HPDefaultPCVideoCardType, HPDefaultPCHardDriveCapacity,
                HPDefaultPCCpuBytes, HPDefaultPCCpuCores);
        }

        public override Server CreateServer()
        {
            return this.ComputerFactory.CreateServer(HPDefaultServerRam, HPDefaultServerHardDriveCapacity, HPDefaultServerCpuBytes,
                HPDefaultServerCpuCores);
        }
    }
}
