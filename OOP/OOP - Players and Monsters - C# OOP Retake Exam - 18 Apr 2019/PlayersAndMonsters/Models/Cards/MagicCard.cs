namespace PlayersAndMonsters.Models.Cards
{
    public class MagicCard : Card
    {
        private const int MagicCardDefaultDamagePoints = 5;
        private const int MagicCardDefaultHealthPoints = 80;
        public MagicCard(string name) 
            : base(name, MagicCardDefaultDamagePoints, MagicCardDefaultHealthPoints)
        {
        }
    }
}
