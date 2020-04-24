namespace HQC_Exam___Computers.ComputerFactories
{
    using HQC_Exam___Computers.ComputerComponents.Contracts;
    using HQC_Exam___Computers.Computers;

    public abstract class AbstractComputerFactory
    {
        public abstract Laptop CreateLaptop();
        public abstract PC CreatePC();
        public abstract Server CreateServer();
    }
}
