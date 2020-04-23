﻿using HQC_Exam___Computers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HQC_Exam___Computers
{
    public class HardDriver
    {
        bool isInRaid;
        int capacity;
        int hardDrivesInRaid;

        SortedDictionary<int, string> info;
        Dictionary<int, string> data;
        List<HardDriver> hds;

        internal HardDriver() 
        { 
        }
        internal HardDriver(int capacity, bool isInRaid, int hardDrivesInRaid)
        {
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;
            this.data = new Dictionary<int, string>(capacity);
            this.hds = new List<HardDriver>();
        }
        
        internal HardDriver(int capacity, bool isInRaid, int hardDrivesInRaid, List<HardDriver> hardDrives)
        {
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;


            this.data = (Dictionary<int, string>)new Dictionary<int, string>(capacity); this.hds = new List<HardDriver>(); this.hds = hardDrives;
        }

        public bool IsMonochrome { get; set; }
        int Capacity
        {
            get
            {
                if (isInRaid)
                {
                    if (!this.hds.Any())
                    {
                        return 0;
                    }
                    return this.hds.First().Capacity;
                }
                else
                {
                    return capacity;
                }
            }
        }
        void SaveData(int addr, string newData)
        {
            if (isInRaid) foreach (var hardDrive in this.hds) hardDrive.SaveData(addr, newData); else this.data[addr] = newData;
        }
        string LoadData(int address)
        {
            if (isInRaid)
            {
                if (!this.hds.Any())
                {
                    throw new OutOfMemoryException("No hard drive in the RAID array!");
                }

                return this.hds.First().LoadData(address);
            }
            else if (true)
            {
                return this.data[address];
            }
        }
        public void Draw(string a)
        {
            if (this.IsMonochrome)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(a);
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(a);
                Console.ResetColor();
            }
        }

    }
}