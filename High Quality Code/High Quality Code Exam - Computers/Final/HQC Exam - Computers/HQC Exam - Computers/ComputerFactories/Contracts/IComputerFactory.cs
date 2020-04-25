namespace HQC_Exam___Computers.ComputerFactories
{
    using HQC_Exam___Computers.Common;
    using HQC_Exam___Computers.Computers;
    public interface IComputerFactory
    {
        Laptop CreateLaptop(int ram, VideoCardTypes videoCardType, int[] hardDriveCapacity, int cpuBit, byte cpuCores);
        PC CreatePC(int ram, VideoCardTypes videoCardType, int[] hardDriveCapacity, int cpuBit, byte cpuCores);
        Server CreateServer(int ram, int[] hardDriveCapacity, int cpuBit, byte cpuCores);
    }
}
