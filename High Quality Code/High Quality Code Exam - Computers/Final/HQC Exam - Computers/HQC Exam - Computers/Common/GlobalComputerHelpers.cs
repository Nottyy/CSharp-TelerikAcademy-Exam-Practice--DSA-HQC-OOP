using System;
using System.Collections.Generic;
using System.Text;

namespace HQC_Exam___Computers.Common
{
    public class GlobalComputerHelpers
    {
        public static int GenerateRandomNumber(int a, int b)
        {
            var rand = new Random();
            int randomNumber = rand.Next(a, b);

            return randomNumber;
        }
    }
}
