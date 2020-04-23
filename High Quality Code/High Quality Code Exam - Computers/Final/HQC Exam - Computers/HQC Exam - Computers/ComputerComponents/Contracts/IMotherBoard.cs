using System;
using System.Collections.Generic;
using System.Text;

namespace HQC_Exam___Computers.Contracts
{
    public interface IMotherboard 
    { 
        int LoadRamValue(); 
        void SaveRamValue(int value); 
        void DrawOnVideoCard(string data);
    }
}
