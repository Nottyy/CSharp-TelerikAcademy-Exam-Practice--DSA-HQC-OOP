namespace HQC_Exam___Computers.ComputerComponents
{
    using System.Linq;
    using HQC_Exam___Computers.ComputerComponents.Contracts;
    using System.Collections.Generic;
    using System;

    public class RaidArray : IHardDrive
    {
        private const string NoHardDisksMessage = "No hard drive in the RAID array!”";

        private IEnumerable<IHardDrive> raidArray;

        public int Capacity => this.raidArray.Count() > 0 ? this.raidArray.FirstOrDefault().Capacity : 0;

        public RaidArray()
        {
            this.raidArray = new List<IHardDrive>();
        }

        public RaidArray(IEnumerable<IHardDrive> hdds)
        {
            this.raidArray = hdds;
        }

        public void SaveData(int address, string newData)
        {
            foreach (var hdd in this.raidArray)
            {
                hdd.SaveData(address, newData);
            }
        }
        public string LoadData(int address)
        {
            if (this.raidArray.Count() == 0)
            {
                throw new OutOfMemoryException(NoHardDisksMessage);
            }
            return this.raidArray.FirstOrDefault().LoadData(address);
        }
    }
}
