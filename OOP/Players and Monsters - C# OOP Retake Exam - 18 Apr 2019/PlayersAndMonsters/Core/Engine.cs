namespace PlayersAndMonsters.Core
{
    using PlayersAndMonsters.Core.Contracts;
    using PlayersAndMonsters.IO.Contracts;
    using System;

    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IManagerController manageController;
        private ICommmandExecuter commandExecuter;
        public Engine(IReader reader, IWriter writer, IManagerController manageController, ICommmandExecuter commandExecuter)
        {
            this.reader = reader;
            this.writer = writer;
            this.manageController = manageController;
            this.commandExecuter = commandExecuter;
        }
        public void Run()
        {
            while (true)
            {
                try
                {
                    var command = reader.ReadLine();
                    var msg = this.commandExecuter.ExecuteCommand(command);
                    if (msg == "Exit")
                    {
                        return;
                    }
                    writer.WriteLine(msg);
                }
                catch (Exception ex)
                {
                    this.writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
