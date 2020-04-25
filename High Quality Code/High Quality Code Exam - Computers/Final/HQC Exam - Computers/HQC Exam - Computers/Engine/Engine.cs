using HQC_Exam___Computers.ComputerFactories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HQC_Exam___Computers
{
    public class Engine : IEngine
    {
        public Engine(AbstractManufacturerFactory manufacturerFactory)
        {
            this.ManufacturerFactory = manufacturerFactory;
        }

        private AbstractManufacturerFactory ManufacturerFactory { get; set; }
        public void Run()
        {
            var laptop = this.ManufacturerFactory.CreateLaptop();
            var pc = this.ManufacturerFactory.CreatePC();
            var server = this.ManufacturerFactory.CreateServer();

            var commandLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (commandLine[0] != "Exit")
            {
                var command = commandLine[0];
                var commandParameter = int.Parse(commandLine[1]);

                switch (command)
                {
                    case "Play":
                        pc.Play(commandParameter);
                        break;
                    case "Charge":
                        laptop.ChargeBattery(commandParameter);
                        break;
                    case "Process":
                        server.Process(commandParameter);
                        break;
                }

                commandLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
