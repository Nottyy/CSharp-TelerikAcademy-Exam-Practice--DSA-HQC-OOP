namespace HQC_Exam___Computers.ComputerComponents
{
    using HQC_Exam___Computers.Contracts;

    public class CPU64 : BaseCPU
    {
        public CPU64(byte numberOfCores) : base(numberOfCores)
        {

        }
        protected override int GetMaxNumber()
        {
            return 1000;
        }
    }
}
