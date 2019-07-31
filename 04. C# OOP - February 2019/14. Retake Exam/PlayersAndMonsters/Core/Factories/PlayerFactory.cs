namespace PlayersAndMonsters.Core.Factories
{
    using Contracts;
    using Models.Players;
    using Models.Players.Contracts;
    using Repositories;

    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer(string type, string username)
        {
            IPlayer player = new Beginner(new CardRepository(), username);
            if (type == "Advanced")
            {
                player = new Advanced(new CardRepository(), username);
            }

            return player;
        }
    }
}
