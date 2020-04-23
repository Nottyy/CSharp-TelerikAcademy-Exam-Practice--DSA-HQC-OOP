using System;
using System.Collections.Generic;
using System.Text;

namespace HQC_Exam___Computers
{
    public class Engine : IEngine
    {

        Computer pc, laptop, server;
        public const int Eight = 8;

        public Engine()
        {

        }
        public void Run()
        {
            var manufacturer = "HP";
            if (manufacturer == "HP")
            {
                var ram = new Ram(Eight / 4);
                var videoCard = new HardDriver() { IsMonochrome = false };
                pc = new Computer(ComputerType.PC, new Cpu(Eight / 4, 32, ram, videoCard), ram, new[] { new HardDriver(500, false, 0) }, videoCard, null);

                var serverRam = new Ram(Eight * 4);
                var serverVideo = new HardDriver();
                server = new Computer(ComputerType.SERVER,
                    new Cpu(Eight / 2, 32, serverRam, serverVideo), serverRam,
                    new List<HardDriver>{
                            new HardDriver(0, true, 2, new List<HardDriver> { new HardDriver(1000, false, 0), new HardDriver(1000, false, 0) })
                        }, serverVideo, null);
                {
                    var card = new HardDriver()
                    {
                        IsMonochrome
                        = false
                    };
                    var ram1 = new Ram(Eight / 2);

                    laptop = new Computer(
                        ComputerType.LAPTOP,
                        new Cpu(Eight / 4, 64, ram1, card),
                        ram1,
                        new[]
                            {
                                new HardDriver(500,
                                    false, 0)
                            },
                        card,
                        new LaptopBattery());
                }
            }
            else if (manufacturer == "Dell")
            {
                var ram = new Ram(Eight); var videoCard = new HardDriver() { IsMonochrome = false };
                pc = new Computer(ComputerType.PC, new Cpu(Eight / 2, 64, ram, videoCard), ram, new[] { new HardDriver(1000, false, 0) }, videoCard, null);
                var ram1 = new Ram(Eight * Eight);
                var card = new HardDriver(); server = new Computer(ComputerType.SERVER,
                     new Cpu(Eight, 64, ram1, card),
                     ram1,
                     new List<HardDriver>{
                            new HardDriver(0, true, 2, new List<HardDriver> { new HardDriver(2000, false, 0), new HardDriver(2000, false, 0) })
                         }, card, null); var ram2 = new Ram(Eight); var videoCard1 = new HardDriver() { IsMonochrome = false };
                laptop = new Computer(ComputerType.LAPTOP,
                    new Cpu(Eight / 2, ((32)), ram2, videoCard1),
                    ram2,
                    new[] { new HardDriver(1000, false, 0) },
                    videoCard1,

                    new LaptopBattery());
            }
            else
            {
                throw new ArgumentException("Invalid manufacturer!");
            }

            var sb = new List<string>();
            string p0 = "Play 5";
            string p1 = "Play 6";
            string p2 = "Charge 10";
            string p3 = "Charge 0";
            string p4 = "Charge -100";
            string p5 = "Charge 200";
            string p6 = "Charge -1";
            string p7 = "Process -1";
            string p8 = "Process 1001";
            string p9 = "Process 1000";
            string p10 = "Process 500";
            string p11 = "Process 16";

            sb.Add(p0);
            sb.Add(p1);
            sb.Add(p2);
            sb.Add(p3);
            sb.Add(p4);
            sb.Add(p5);
            sb.Add(p6);
            sb.Add(p7);
            sb.Add(p8);
            sb.Add(p9);
            sb.Add(p10);
            sb.Add(p11);
            sb.Add("Exit");
            foreach (var c in sb)
            {
                if (c == "Exit")
                {
                    return;
                }

                var cp = c.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (cp.Length != 2)
                {
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                }
                var cn = cp[0];
                var ca = int.Parse(cp[1]);

                if (cn == "Charge") laptop.ChargeBattery(ca);
                else if (cn == "Process") server.Process(ca);
                else if (cn == "Play") pc.Play(ca);
            }


            //while (true)
            //{
            //    var c = Console.ReadLine();
            //    if (c == "Exit")
            //    {
            //        return;
            //    }

            //    var cp = c.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    if (cp.Length != 2)
            //    {
            //        {
            //            throw new ArgumentException("Invalid command!");
            //        }
            //    }
            //    var cn = cp[0];
            //    var ca = int.Parse(cp[1]);



            //    if (cn == "Charge") laptop.ChargeBattery(ca);
            //    else if (cn == "Process") server.Process(ca);
            //    else if (cn == "Play") pc.Play(ca);
            //}
        }
    }
}
