namespace PlayersAndMonsters.Models.BattleFields
{
    using System;
    using System.Linq;
    using PlayersAndMonsters.Models.BattleFields.Contracts;
    using PlayersAndMonsters.Models.Players;
    using PlayersAndMonsters.Models.Players.Contracts;

    public class Battlefield : IBattleField
    {
        private const int BeginnerBonusHealth = 40;
        private const int BeginnerBonusCardDamagePoints = 30;
        private void SetBeginnerValues(IPlayer player)
        {
            player.Health += BeginnerBonusHealth;

            foreach (var card in player.CardRepository.Cards)
            {
                card.DamagePoints += BeginnerBonusCardDamagePoints;
            }
        }
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            if (attackPlayer.GetType() == typeof(Beginner))
            {
                this.SetBeginnerValues(attackPlayer);
            }
            if (enemyPlayer.GetType() == typeof(Beginner))
            {
                this.SetBeginnerValues(enemyPlayer);
            }

            attackPlayer.Health += attackPlayer.CardRepository.Cards.Sum(pl => pl.HealthPoints);
            enemyPlayer.Health += enemyPlayer.CardRepository.Cards.Sum(pl => pl.HealthPoints);

            var attackPlayerDamagePoints = attackPlayer.CardRepository.Cards.Sum(x => x.DamagePoints);
            var enemyPlayerDamagePoints = enemyPlayer.CardRepository.Cards.Sum(x => x.DamagePoints);
            while (true)
            {
                enemyPlayer.TakeDamage(attackPlayerDamagePoints);
                if (enemyPlayer.IsDead)
                {
                    break;
                }

                attackPlayer.TakeDamage(enemyPlayerDamagePoints);
                if (attackPlayer.IsDead)
                {
                    break;
                }
            }
        }
    }
}
