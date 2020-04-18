namespace PlayersAndMonsters
{
    using Core;
    using Core.Contracts;
    using Core.Factories;
    using Core.Factories.Contracts;
    using Repositories;
    using Repositories.Contracts;
    using IO;
    using IO.Contracts;
    using Models.BattleFields;
    using Models.BattleFields.Contracts;
    using PlayersAndMonsters.Models.Players;
    using PlayersAndMonsters.Models.Cards;
    using System.Collections.Generic;
    using PlayersAndMonsters.Models.Cards.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IReader reader = new Reader();
            IWriter writer = new Writer();
            IManagerController manageController = new ManagerController();
            ICommmandExecuter commandExecuter = new CommandExecuter(manageController);
            IEngine engine = new Engine(reader, writer, manageController, commandExecuter);
            engine.Run();
        }
    }
}