using System;
using System.Collections.Generic;
using System.Text;

namespace HQC_Exam___Computers
{
    public class Rammstein
    {
        int value;
        internal Rammstein(int a)
        {
            Amount = a;
        }
        int Amount { get; set; }
        public void SaveValue(int newValue)
        {
            value = newValue;
        }
        public int LoadValue()
        {
            return value;
        }
    }
}
