namespace PlayersAndMonsters.Core.Factories
{
    using Contracts;
    using Models.Cards;
    using Models.Cards.Contracts;


    public class CardFactory : ICardFactory
    {
        public ICard CreateCard(string type, string name)
        {
            ICard card = new MagicCard(name);
            if (type == "Trap")
            {
                card = new TrapCard(name);
            }

            return card;
        }
    }
}
