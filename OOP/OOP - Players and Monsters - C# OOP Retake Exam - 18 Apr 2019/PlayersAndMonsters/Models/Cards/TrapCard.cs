namespace PlayersAndMonsters.Models.Cards
{
    public class TrapCard : Card
    {
        private const int TrapCardDefaultDamagePoints = 120;
        private const int TrapCardDefaultHealthPoints = 5;
        public TrapCard(string name) 
            : base(name, TrapCardDefaultDamagePoints, TrapCardDefaultHealthPoints)
        {
        }
    }
}
