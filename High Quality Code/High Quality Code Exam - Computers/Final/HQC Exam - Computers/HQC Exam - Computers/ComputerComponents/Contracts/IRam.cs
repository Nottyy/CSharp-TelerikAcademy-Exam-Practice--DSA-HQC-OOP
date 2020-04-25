using System;
using System.Collections.Generic;
using System.Text;

namespace HQC_Exam___Computers.ComputerComponents.Contracts
{
    public interface IRam : IMotherboardComponent
    {
        int MaxAmount { get; }
        void SaveValue(int value);
        int LoadValue();
    }
}
