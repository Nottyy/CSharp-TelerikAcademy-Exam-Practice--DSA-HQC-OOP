namespace HQC_Exam___Computers.ComputerComponents
{
    using HQC_Exam___Computers.ComputerComponents.Contracts;
    using HQC_Exam___Computers.Contracts;

    public abstract class MotherboardComponent : IMotherboardComponent
    {
        public IMotherboard MotherboardMediator { get; set; }
    }
}
