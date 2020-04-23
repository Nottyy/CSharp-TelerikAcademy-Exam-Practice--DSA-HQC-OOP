﻿using HQC_Exam___Computers.ComputerComponents.Contracts;
namespace HQC_Exam___Computers.ComputerComponents
{
    using HQC_Exam___Computers.Contracts;
    public class CPU32 : CPU
    {
        public CPU32(byte numberOfCores, IMotherboard motherboard) : base(numberOfCores, motherboard)
        {

        }
        protected override int GetMaxNumber()
        {
            return 500;
        }
    }
}
