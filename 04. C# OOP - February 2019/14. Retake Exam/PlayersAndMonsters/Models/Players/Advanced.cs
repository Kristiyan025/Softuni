namespace PlayersAndMonsters.Models.Players
{
    using Repositories.Contracts;

    public class Advanced : Player
    {
        public Advanced(ICardRepository cardRepository, string username)
            : base(cardRepository, username, 250)
        {
        }
    }
}
