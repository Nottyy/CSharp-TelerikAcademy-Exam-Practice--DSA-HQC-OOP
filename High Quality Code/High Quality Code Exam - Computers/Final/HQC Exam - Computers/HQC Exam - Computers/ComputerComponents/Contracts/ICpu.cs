using System;
using System.Collections.Generic;
using System.Text;

namespace HQC_Exam___Computers.ComputerComponents.Contracts
{
    public interface ICpu : IMotherboardComponent
    {
        byte NumberOfCores { get; }
        void GenerateRandomNumberAndSaveToRam(int min, int max);
        void CalculateSquare();
    }
}
