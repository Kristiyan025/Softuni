namespace PlayersAndMonsters.Repositories
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Models.Cards.Contracts;
    using Contracts;

    public class CardRepository : ICardRepository
    {
        private List<ICard> cards;

        public CardRepository()
        {
            this.cards=new List<ICard>();
        }

        public int Count { get => this.Cards.Count; }

        public IReadOnlyCollection<ICard> Cards { get => this.cards; }

        public void Add(ICard card)
        {
            if (card is null)
            {
                throw new ArgumentException("Card cannot be null!");
            }

            if (this.Cards.Where(x => x.Name == card.Name).Count() != 0)
            {
                throw new ArgumentException($"Card {card.Name} already exists!");
            }

            this.cards.Add(card);
        }

        public bool Remove(ICard card)
        {
            if (card is null)
            {
                throw new ArgumentException("Card cannot be null!");
            }

            if (this.Cards.Where(x => x.Name == card.Name).Count() == 0)
            {
                return false;
            }

            this.cards.Remove(card);
            return true;
        }

        public ICard Find(string name)
        {
            var card = this.Cards.FirstOrDefault(x => x.Name == name);
            if (card is null)
            {
                throw new ArgumentException("Card doesn't exist");
            }

            return card;
        }
    }
}
