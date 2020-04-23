﻿namespace HQC_Exam___Computers
{
    using HQC_Exam___Computers.Common;
    using HQC_Exam___Computers.ComputerComponents.Contracts;
    using HQC_Exam___Computers.Contracts;
    using System;
    public abstract class CPU : ICpu
    {
        private const string LowNumberMessage = "Number too low.";
        private const string HighNumberMessage = "Number too high.";
        private const string SquareMessage = "Square of {0} is {1}.";
        private IMotherboard motherBoard;

        public CPU(byte numberOfCores, IMotherboard motherBoard)
        {
            this.motherBoard = motherBoard;
            this.NumberOfCores = numberOfCores;
        }

        public byte NumberOfCores { get; private set; }
        

        public void GenerateRandomNumberAndSaveToRam(int a, int b)
        {
            int randomNumber = GlobalComputerHelpers.GenerateRandomNumber(a, b);
            this.motherBoard.SaveRamValue(randomNumber);
        }

        public void CalculateSquare()
        {
            var squareNum = this.motherBoard.LoadRamValue();
            if (squareNum < 0)
            {
                this.motherBoard.DrawOnVideoCard(LowNumberMessage);
            }
            else if (squareNum >= this.GetMaxNumber())
            {
                this.motherBoard.DrawOnVideoCard(HighNumberMessage);
            }
            else
            {
                var square = squareNum * squareNum;
                this.motherBoard.DrawOnVideoCard(string.Format(SquareMessage, squareNum, square));
            }
        }

        protected abstract int GetMaxNumber();
    }
}
