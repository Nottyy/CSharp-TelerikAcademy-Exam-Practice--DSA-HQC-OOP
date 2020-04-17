namespace PlayersAndMonsters.Core
{
    using System;
    using System.Text;
    using Contracts;
    using PlayersAndMonsters.Common;
    using PlayersAndMonsters.Core.Factories;
    using PlayersAndMonsters.Core.Factories.Contracts;
    using PlayersAndMonsters.Models.BattleFields;
    using PlayersAndMonsters.Models.BattleFields.Contracts;
    using PlayersAndMonsters.Repositories;
    using PlayersAndMonsters.Repositories.Contracts;

    public class ManagerController : IManagerController
    {
        ICardFactory cardfactory;
        IPlayerFactory playerFactory;
        ICardRepository cardRepository;
        IPlayerRepository playerRepository;
        IBattleField battlefield;
        public ManagerController()
        {
            this.cardfactory = new CardFactory();
            this.playerFactory = new PlayerFactory();
            this.cardRepository = new CardRepository();
            this.playerRepository = new PlayerRepository();
            this.battlefield = new Battlefield();
        }

        public string AddPlayer(string type, string username)
        {
            var player = this.playerFactory.CreatePlayer(type, username);
            this.playerRepository.Add(player);

            var message = string.Format(ConstantMessages.SuccessfullyAddedPlayer, type, username);
            return message;
        }

        public string AddCard(string type, string name)
        {
            var card = this.cardfactory.CreateCard(type, name);
            this.cardRepository.Add(card);

            var message = string.Format(ConstantMessages.SuccessfullyAddedCard, type, name);
            return message;
        }

        public string AddPlayerCard(string username, string cardName)
        {
            var card = this.cardRepository.Find(cardName);
            var player = this.playerRepository.Find(username);

            player.CardRepository.Add(card);

            var message = string.Format(ConstantMessages.SuccessfullyAddedPlayerWithCards, cardName, username);

            return message;
        }

        public string Fight(string attackUser, string enemyUser)
        {
            var attackPlayer = this.playerRepository.Find(attackUser);
            var enemyPlayer = this.playerRepository.Find(enemyUser);

            this.battlefield.Fight(attackPlayer, enemyPlayer);

            var message = string.Format(ConstantMessages.FightInfo, attackPlayer.Health, enemyPlayer.Health);

            return message;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var player in playerRepository.Players)
            {
                var playerMessage = string.Format(ConstantMessages.PlayerReportInfo, player.Username, player.Health, player.CardRepository.Count);
                sb.AppendLine(playerMessage);

                foreach (var playerCard in player.CardRepository.Cards)
                {
                    var cardMessage = string.Format(ConstantMessages.CardReportInfo, playerCard.Name, playerCard.DamagePoints);
                    sb.AppendLine(cardMessage);
                }

                sb.AppendLine(ConstantMessages.DefaultReportSeparator);
            }

            return sb.ToString();
        }
    }
}
