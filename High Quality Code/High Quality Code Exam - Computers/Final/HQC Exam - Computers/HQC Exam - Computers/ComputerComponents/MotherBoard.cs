using HQC_Exam___Computers.ComputerComponents.Contracts;
namespace HQC_Exam___Computers.ComputerComponents
{
    using HQC_Exam___Computers.Contracts;

    public class MotherBoard : IMotherboard
    {
        private IRam ram { get; set; }
        private IVideoCard videoCard { get; set; }

        public MotherBoard(IVideoCard videoCard, IRam ram)
        {
            this.videoCard = videoCard;
            this.ram = ram;
        }
        public void DrawOnVideoCard(string data)
        {
            this.videoCard.Draw(data);
        }

        public int LoadRamValue()
        {
            var value = this.ram.LoadValue();
            return value;
        }

        public void SaveRamValue(int value)
        {
            this.ram.SaveValue(value);
        }
    }
}
