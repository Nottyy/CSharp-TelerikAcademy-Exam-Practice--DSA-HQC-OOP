namespace HQC_Exam___Computers
{
    using HQC_Exam___Computers;
    using HQC_Exam___Computers.ComputerFactories;
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            IComputerFactory computerFactory = new ComputerFactory();
            AbstractManufacturerFactory ManufactuererCompany = CreateManufacturer(command, computerFactory);

            IEngine engine = new Engine(ManufactuererCompany);
            engine.Run();
        }

        private static AbstractManufacturerFactory CreateManufacturer(string manufacturerName, IComputerFactory computerFactory)
        {
            AbstractManufacturerFactory manufacturer;

            if (manufacturerName == DELLFactory.DELLFactoryName)
            {
                manufacturer = new DELLFactory(computerFactory);
            }
            else if (manufacturerName == HPFactory.HPFactoryName)
            {
                manufacturer = new HPFactory(computerFactory);
            }
            else
            {
                manufacturer = new LenovoFactory(computerFactory);
            }

            return manufacturer;
        }
    }
}
