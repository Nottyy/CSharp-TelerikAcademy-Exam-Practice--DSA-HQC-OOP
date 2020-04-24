namespace HQC_Exam___Computers
{
    using HQC_Exam___Computers.Common;
    using HQC_Exam___Computers.ComputerComponents;
    using HQC_Exam___Computers.ComputerComponents.Contracts;
    using HQC_Exam___Computers.Contracts;
    using System;
    public abstract class BaseCPU : MotherboardComponent, ICpu
    {
        private const string LowNumberMessage = "Number too low.";
        private const string HighNumberMessage = "Number too high.";
        private const string SquareMessage = "Square of {0} is {1}.";

        public BaseCPU(byte numberOfCores)
        {
            this.NumberOfCores = numberOfCores;
        }

        public byte NumberOfCores { get; private set; }
        

        public void GenerateRandomNumberAndSaveToRam(int a, int b)
        {
            int randomNumber = GlobalComputerHelpers.GenerateRandomNumber(a, b);
            this.MotherboardMediator.SaveRamValue(randomNumber);
        }

        public void CalculateSquare()
        {
            var squareNum = this.MotherboardMediator.LoadRamValue();
            if (squareNum < 0)
            {
                this.MotherboardMediator.DrawOnVideoCard(LowNumberMessage);
            }
            else if (squareNum >= this.GetMaxNumber())
            {
                this.MotherboardMediator.DrawOnVideoCard(HighNumberMessage);
            }
            else
            {
                var square = squareNum * squareNum;
                this.MotherboardMediator.DrawOnVideoCard(string.Format(SquareMessage, squareNum, square));
            }
        }

        protected abstract int GetMaxNumber();
    }
}
