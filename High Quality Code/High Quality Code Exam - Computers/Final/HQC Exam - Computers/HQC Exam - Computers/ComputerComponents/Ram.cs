namespace HQC_Exam___Computers
{
    using HQC_Exam___Computers.ComputerComponents;
    using HQC_Exam___Computers.ComputerComponents.Contracts;

    public class Ram : MotherboardComponent, IRam
    {
        private int value;
        internal Ram(int amount)
        {
            this.MaxAmount = amount;
        }
        public int MaxAmount { get; private set; }

        public void SaveValue(int newValue)
        {
            this.value = newValue;
        }
        public int LoadValue()
        {
            return value;
        }
    }
}
