using System;
using System.Collections.Generic;
using System.Text;

namespace HQC_Exam___Computers.ComputerComponents.Contracts
{
    public interface IBattery
    {
        void Charge(int amountToCharge);
        int Percentage { get; }
    }
}
