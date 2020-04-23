namespace HQC_Exam___Computers
{
    using HQC_Exam___Computers.ComputerComponents.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HardDriver : IHardDrive
    {
        private IDictionary<int, string> data;
        public int Capacity { get; private set; }

        public HardDriver(int capacity)
        {
            this.Capacity = capacity;
            this.data = new Dictionary<int, string>(capacity);
        }
        public void SaveData(int address, string newData)
        {
            this.data.Add(address, newData);
        }
        public string LoadData(int address)
        {
            return this.data[address];
        }

        //throw new OutOfMemoryException("No hard drive in the RAID array!");
    }
}
