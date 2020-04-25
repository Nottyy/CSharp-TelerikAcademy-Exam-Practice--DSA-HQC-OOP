namespace HQC_Exam___Computers.ComputerFactories
{
    using HQC_Exam___Computers.Common;
    using HQC_Exam___Computers.ComputerComponents;
    using HQC_Exam___Computers.Computers;
    public class DELLFactory : AbstractManufacturerFactory
    {
        public const string DELLFactoryName = "Dell";

        private const int DellDefaultLaptopRam = 8;
        private const int DellDefaultPCRam = 8;
        private const int DellDefaultServerRam = 64;

        private const VideoCardTypes DellDefaultLaptopVideoCardType = VideoCardTypes.ColorFul;
        private const VideoCardTypes DellDefaultPCVideoCardType = VideoCardTypes.ColorFul;

        private readonly int[] DellDefaultLaptopHardDriveCapacity = new int[1] { 1000 };
        private readonly int[] DellDefaultPCHardDriveCapacity = new int[] { 1000 };
        private readonly int[] DellDefaultServerHardDriveCapacity = new int[] { 2000, 2000 };

        private const int DellDefaultLaptopCpuBytes = 32;
        private const int DellDefaultPCCpuBytes = 64;
        private const int DellDefaultServerCpuBytes = 64;

        private const byte DellDefaultLaptopCpuCores = 4;
        private const byte DellDefaultPCCpuCores = 4;
        private const byte DellDefaultServerCpuCores = 8;

        public DELLFactory(IComputerFactory compFactory) : base(compFactory)
        {
        }

        public override Laptop CreateLaptop()
        {
            return this.ComputerFactory.CreateLaptop(DellDefaultLaptopRam, DellDefaultLaptopVideoCardType,
                DellDefaultLaptopHardDriveCapacity, DellDefaultLaptopCpuBytes, DellDefaultLaptopCpuCores);
        }

        public override PC CreatePC()
        {
            return this.ComputerFactory.CreatePC(DellDefaultPCRam, DellDefaultPCVideoCardType, DellDefaultPCHardDriveCapacity,
                DellDefaultPCCpuBytes, DellDefaultPCCpuCores);
        }

        public override Server CreateServer()
        {
            return this.ComputerFactory.CreateServer(DellDefaultServerRam, DellDefaultServerHardDriveCapacity, DellDefaultServerCpuBytes,
                DellDefaultServerCpuCores);
        }
    }
}
