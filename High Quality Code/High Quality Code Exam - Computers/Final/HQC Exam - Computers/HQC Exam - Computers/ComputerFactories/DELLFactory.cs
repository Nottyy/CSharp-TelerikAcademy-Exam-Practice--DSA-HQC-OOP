namespace HQC_Exam___Computers.ComputerFactories
{
    using HQC_Exam___Computers.ComputerComponents;
    using HQC_Exam___Computers.Computers;
    public class DELLFactory : AbstractComputerFactory
    {
        public override Laptop CreateLaptop()
        {
            var laptopRam = new Ram(8);
            var laptopVideoCard = new ColorfulVideoCard();
            var laptopHardDrive = new HardDriver(1000);
            var laptopMotherBoard = new MotherBoard(videoCard,ram,cpu)
            var laptopCPU = new CPU64()
        }

        public override PC CreatePC()
        {
            throw new System.NotImplementedException();
        }

        public override Server CreateServer()
        {
            throw new System.NotImplementedException();
        }
    }
}
