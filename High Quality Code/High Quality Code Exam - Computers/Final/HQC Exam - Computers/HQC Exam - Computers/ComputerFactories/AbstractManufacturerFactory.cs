namespace HQC_Exam___Computers.ComputerFactories
{
    using HQC_Exam___Computers.ComputerComponents.Contracts;
    using HQC_Exam___Computers.Computers;

    public abstract class AbstractManufacturerFactory
    {
        public AbstractManufacturerFactory(IComputerFactory compFactory)
        {
            this.ComputerFactory = compFactory;
        }

        protected IComputerFactory ComputerFactory { get; set; }
        public abstract Laptop CreateLaptop();
        public abstract PC CreatePC();
        public abstract Server CreateServer();
    }
}
