using System;

namespace HQC_Exam___Computers.ComputerComponents.Contracts
{
    public interface IVideoCard : IMotherboardComponent
    {
        void Draw(string msg);
    }
}
