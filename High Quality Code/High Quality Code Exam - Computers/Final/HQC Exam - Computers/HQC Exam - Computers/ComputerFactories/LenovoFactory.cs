using HQC_Exam___Computers.Common;
using HQC_Exam___Computers.ComputerComponents;
using HQC_Exam___Computers.Computers;

namespace HQC_Exam___Computers.ComputerFactories
{
    public class LenovoFactory : AbstractManufacturerFactory
    {
        public const string LENOVOFactoryName = "Lenovo";

        private const int LenovoDefaultLaptopRam = 16;
        private const int LenovoefaultPCRam = 4;
        private const int LenovoefaultServerRam = 8;

        private const VideoCardTypes LenovoDefaultLaptopVideoCardType = VideoCardTypes.ColorFul;
        private const VideoCardTypes LenovoDefaultPCVideoCardType = VideoCardTypes.Monochrome;

        private readonly int[] LenovoDefaultLaptopHardDriveCapacity = new int[1] { 1000 };
        private readonly int[] LenovoDefaultPCHardDriveCapacity = new int[] { 2000 };
        private readonly int[] LenovoDefaultServerHardDriveCapacity = new int[] { 500, 500 };

        private const int LenovoDefaultLaptopCpuBytes = 64;
        private const int LenovoDefaultPCCpuBytes = 64;
        private const int LenovoDefaultServerCpuBytes = 128;

        private const byte LenovoDefaultLaptopCpuCores = 2;
        private const byte LenovoDefaultPCCpuCores = 2;
        private const byte LenovoDefaultServerCpuCores = 2;

        public LenovoFactory(IComputerFactory compFactory) : base(compFactory)
        {
        }

        public override Laptop CreateLaptop()
        {
            return this.ComputerFactory.CreateLaptop(LenovoDefaultLaptopRam, LenovoDefaultLaptopVideoCardType,
                LenovoDefaultLaptopHardDriveCapacity, LenovoDefaultLaptopCpuBytes, LenovoDefaultLaptopCpuCores);
        }

        public override PC CreatePC()
        {
            return this.ComputerFactory.CreatePC(LenovoDefaultLaptopRam, LenovoDefaultLaptopVideoCardType,
                LenovoDefaultLaptopHardDriveCapacity, LenovoDefaultLaptopCpuBytes, LenovoDefaultLaptopCpuCores);
        }

        public override Server CreateServer()
        {
            return this.ComputerFactory.CreateServer(LenovoDefaultLaptopRam, LenovoDefaultLaptopHardDriveCapacity, LenovoDefaultLaptopCpuBytes, 
                LenovoDefaultLaptopCpuCores);
        }
    }
}
