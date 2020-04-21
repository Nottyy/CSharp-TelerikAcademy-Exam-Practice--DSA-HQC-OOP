namespace PlayersAndMonsters.Repositories
{
    using PlayersAndMonsters.Models.Cards.Contracts;
    using PlayersAndMonsters.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CardRepository : ICardRepository
    {
        private List<ICard> cards;
        public CardRepository()
        {
            this.cards = new List<ICard>();
        }
        public int Count => this.Cards.Count();

        public IReadOnlyCollection<ICard> Cards => this.cards;

        public void Add(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentException("Card cannot be null.");
            }

            bool ifPlayerExcists = this.cards.Any(x => x.Name == card.Name);
            if (ifPlayerExcists)
            {
                throw new ArgumentException(string.Format("Card {0} already exists!", card.Name));
            }

            this.cards.Add(card);
        }

        public ICard Find(string name)
        {
            return this.cards.FirstOrDefault(x => x.Name == name);
        }

        public bool Remove(ICard card)
        {
            bool isRemoved = this.cards.Remove(card);

            return isRemoved;
        }
    }
}
