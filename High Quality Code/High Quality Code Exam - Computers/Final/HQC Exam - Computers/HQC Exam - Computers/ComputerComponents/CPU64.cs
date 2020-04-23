namespace HQC_Exam___Computers.ComputerComponents
{
    using HQC_Exam___Computers.Contracts;

    public class CPU64 : CPU
    {
        public CPU64(byte numberOfCores, IMotherboard motherboard) : base(numberOfCores, motherboard)
        {

        }
        protected override int GetMaxNumber()
        {
            return 1000;
        }
    }
}
