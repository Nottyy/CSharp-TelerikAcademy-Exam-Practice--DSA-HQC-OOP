using HQC_Exam___Computers.ComputerComponents.Contracts;
namespace HQC_Exam___Computers.ComputerComponents
{
    using HQC_Exam___Computers.Contracts;
    public class CPU32 : BaseCPU
    {
        public CPU32(byte numberOfCores) : base(numberOfCores)
        {

        }
        protected override int GetMaxNumber()
        {
            return 500;
        }
    }
}
