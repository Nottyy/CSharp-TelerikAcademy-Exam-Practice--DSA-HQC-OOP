namespace HQC_Exam___Computers.ComputerComponents
{
    using HQC_Exam___Computers.Contracts;

    public class CPU128 : CPU
    {
        public CPU128(byte numberOfCores, IMotherboard motherboard) : base(numberOfCores, motherboard)
        {
        }
        protected override int GetMaxNumber()
        {
            return 2000;
        }
    }
}
