namespace 
    HQC_Exam___Computers.ComputerComponents
{
    using HQC_Exam___Computers.ComputerComponents.Contracts;
    using HQC_Exam___Computers.Contracts;

    public class MotherBoard : IMotherboard
    {
        private IRam Ram { get; set; }
        private IVideoCard VideoCard { get; set; }
        private ICpu Cpu { get; set; }

        public MotherBoard(IVideoCard videoCard, IRam ram, ICpu cpu)
        {
            this.VideoCard = videoCard;
            this.Ram = ram;
            this.Cpu = cpu;
        }
        public void DrawOnVideoCard(string data)
        {
            this.VideoCard.Draw(data);
        }

        public int LoadRamValue()
        {
            var value = this.Ram.LoadValue();
            return value;
        }

        public void SaveRamValue(int value)
        {
            this.Ram.SaveValue(value);
        }
    }
}
