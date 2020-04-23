using System;
using System.Collections.Generic;
using System.Text;

namespace HQC_Exam___Computers.ComputerComponents.Contracts
{
    interface ICpu
    {
        int NumberOfCores { get; }
        void GenerateRandomNumberAndSaveToRam(IRam ram, int min, int max);
        void CalculateSquare();
    }
}
