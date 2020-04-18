using PlayersAndMonsters.Core.Contracts;
using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories;
using System;

namespace PlayersAndMonsters.Core
{
    public class CommandExecuter : ICommmandExecuter
    {
        private IManagerController manageController;

        public CommandExecuter(IManagerController manageController)
        {
            this.manageController = manageController;
        }
        public string ExecuteCommand(string command)
        {
            var commandAsArray = command.Split(new[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            var commandName = commandAsArray[0];
            if (commandName == "Exit")
            {
                return commandName;
            }

            var commandMessage = "";
            switch (commandName)
            {
                case "AddPlayer":
                    var playerTypeAsString = commandAsArray[1];
                    var playerName = commandAsArray[2];

                    commandMessage = this.manageController.AddPlayer(playerTypeAsString, playerName);
                    break;
                case "AddCard":
                    var cardTypeAsString = commandAsArray[1];
                    var cardName = commandAsArray[2];

                    commandMessage = this.manageController.AddCard(cardTypeAsString, cardName);
                    break;
                case "AddPlayerCard":
                    var playerNameForCardToBeAdded = commandAsArray[1];
                    var cardNameForPlayer = commandAsArray[2];

                    commandMessage = this.manageController.AddPlayerCard(playerNameForCardToBeAdded, cardNameForPlayer);
                    break;
                case "Fight":
                    var attackPlayer = commandAsArray[1];
                    var enemyPlayer = commandAsArray[2];

                    commandMessage = this.manageController.Fight(attackPlayer, enemyPlayer);
                    break;
                case "Report":
                    commandMessage = this.manageController.Report();
                    break;
            }

            return commandMessage;
        }
    }
}
