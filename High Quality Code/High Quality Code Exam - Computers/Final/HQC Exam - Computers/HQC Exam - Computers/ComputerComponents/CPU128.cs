namespace HQC_Exam___Computers.ComputerComponents
{
    using HQC_Exam___Computers.Contracts;

    public class CPU128 : BaseCPU
    {
        public CPU128(byte numberOfCores) : base(numberOfCores)
        {
        }
        protected override int GetMaxNumber()
        {
            return 2000;
        }
    }
}
