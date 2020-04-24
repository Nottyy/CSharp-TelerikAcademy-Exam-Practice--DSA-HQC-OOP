namespace HQC_Exam___Computers.Computers
{
    using HQC_Exam___Computers.ComputerComponents;
    using HQC_Exam___Computers.ComputerComponents.Contracts;
    using System.Collections.Generic;
    public class Server : BaseComputer
    {
        public Server(ICpu cpu, IRam ram, IEnumerable<IHardDrive> hardDrives) : base(cpu, ram, new MonochromeVideoCard(), hardDrives)
        {
        }

        public void Process(int data)
        {
            this.Ram.SaveValue(data);
            this.CPU.CalculateSquare();
        }
    }
}
